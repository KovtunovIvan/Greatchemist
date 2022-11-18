<template>
    <div>
        <p class="customTitle">Результаты</p>
        <div v-if="!loaded" class="text-center">
            <v-progress-circular indeterminate
                                    color="#000"
                                    :size="70"></v-progress-circular>
        </div>
        <div v-else class="text-center">
            123
        </div>
    </div>
</template>

<script>
    export default {
        name: 'result',
        data: () => ({
            loaded: false,
            results: null,
        }),

        props: {
            iteration: {
                type: Number,
                required: true
            },
        },

        methods: {
            loadPage() {
                this.loaded = false
                this.$http
                    .get(this.$store.state.baseUrl + `api/result/getUserResults?email=` + this.$store.state.email + `&iteration=` + this.iteration)
                    .then(response => {
                        this.results = response.data
                        this.loaded = true
                    })
                    .catch(e => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка загрузки результатов"
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