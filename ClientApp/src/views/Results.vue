<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/`)">Назад</button>
        <div class="customInf" style="max-height: 70vh; overflow: auto;">
            <p class="customTitle">Результаты</p>
            <div v-if="!loaded" class="text-center">
                <v-progress-circular indeterminate
                                     color="#000"
                                     :size="70"></v-progress-circular>
            </div>
            <div v-else class="text-center">
                <v-expansion-panels>
                    <v-expansion-panel v-for="(item,i) in iterations"
                                       :key="i">
                        <v-expansion-panel-header>
                            Результаты от {{item.date | dateFormat}}
                        </v-expansion-panel-header>
                        <v-expansion-panel-content>
                            <app-result :iteration="item.id"></app-result>
                        </v-expansion-panel-content>
                    </v-expansion-panel>
                </v-expansion-panels>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Results',
        data: () => ({
            loaded: false,
            iterations: null,
        }),

        methods: {
            loadPage() {
                this.loaded = false

                if (!this.$store.state.isAuthorized || !this.$store.state.email || this.$store.state.email.length == 0) {
                    this.$store.state.snackbarShow = false
                    this.$store.state.snackbarColor = "#ff5252"
                    this.$store.state.snackbarText = "Необходимо авторизоваться"
                    this.$store.state.snackbarShow = true
                    this.$router.push({ path: '/SignIn' })
                } else {
                    this.$http
                        .get(this.$store.state.baseUrl + `api/result/getUserIterations?email=` + this.$store.state.email)
                        .then(response => {
                            this.iterations = response.data
                            this.loaded = true
                        })
                        .catch(e => {
                            this.$store.state.snackbarShow = false
                            this.$store.state.snackbarColor = "#ff5252"
                            this.$store.state.snackbarText = "Ошибка загрузки попыток"
                            this.$store.state.snackbarShow = true

                            console.log(e)
                        });
                }                
            },
        },

        created() {
            this.loadPage()
        },
    };
</script>