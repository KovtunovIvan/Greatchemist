<template>
    <div>
        <p class="customTitle">Результаты</p>
        <div v-if="!loaded" class="text-center">
            <v-progress-circular indeterminate
                                    color="#000"
                                    :size="70"></v-progress-circular>
        </div>
        <div v-else class="text-center">
            <table>
                <tr>
                    <td rowspan="2">Задание</td>
                    <td colspan="2">Параллель 1</td>
                    <td colspan="2">Параллель 2</td>
                </tr>
                <tr>
                    <td>Ошибки</td>
                    <td>Время</td>
                    <td>Ошибки</td>
                    <td>Время</td>
                </tr>
                <tr v-for="result in results">
                    <td>{{result.officialNumber}} {{result.title}}</td>
                    <td>Ошибки</td>
                    <td>Время</td>
                    <td>Ошибки</td>
                    <td>Время</td>
                </tr>
            </table>
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

<style>
    table{
        width:100%;
    }
    table, th, td {
        border: 1px solid black;
        border-collapse: collapse;
    }
</style>