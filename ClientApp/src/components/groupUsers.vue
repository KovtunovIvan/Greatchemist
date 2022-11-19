<template>
    <div>
        <div v-if="!loaded" class="text-center">
            <v-progress-circular indeterminate
                                    color="#000"
                                    :size="70"></v-progress-circular>
        </div>
        <div v-else class="text-center">
            <v-expansion-panels>
                <v-expansion-panel v-for="(user,i) in users"
                                   :key="i">
                    <v-expansion-panel-header>
                        {{user.name}}
                    </v-expansion-panel-header>
                    <v-expansion-panel-content>
                        <app-student-results :email="user.email"></app-student-results>
                    </v-expansion-panel-content>
                </v-expansion-panel>
            </v-expansion-panels>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'GroupUsers',

        props: {
            groupId: {
                type: Number,
                required: true
            },
        },

        data: () => ({
            loaded: false,
            users: null,
        }),

        methods: {
            loadPage() {
                this.loaded = false
                this.$http
                    .get(this.$store.state.baseUrl + `api/User/GetGroupUsers?groupId=` + this.groupId)
                    .then(response => {
                        this.users = response.data
                        this.loaded = true
                    })
                    .catch(e => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка загрузки учеников"
                        this.$store.state.snackbarShow = true

                        console.log(e)
                    });             
            },
        },

        created() {
            this.loadPage()
        },
    };
</script>