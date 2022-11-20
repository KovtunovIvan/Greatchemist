<template>
    <div>
        <div v-if="!loaded" class="text-center">
            <v-progress-circular indeterminate
                                    color="#000"
                                    :size="70"></v-progress-circular>
        </div>
        <div v-else class="text-center">
            <a href="../results.csv" download="GCResults">Скачать результаты</a>
            <table class="results">
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
                <tr v-for="result in results.r1">
                    <td style="text-align:left;">{{result.officialNumber}}.&nbsp;{{result.title}}</td>
                    <td>{{result.mistakes1}}</td>
                    <td>{{difTime(result.startTime1,result.endTime1)}}</td>
                    <td>{{result.mistakes2}}</td>
                    <td>{{difTime(result.startTime2,result.endTime2)}}</td>
                </tr>
            </table>
            <br />
            <table class="results">
                <tr>
                    <td>Задание</td>
                    <td>Время</td>
                    <td>Ответ</td>
                </tr>
                <tr v-for="result in results.r2">
                    <td style="text-align: left; vertical-align: top;">{{result.officialNumber}}.&nbsp;{{result.title}}</td>
                    <td style="vertical-align: top;">{{difTime(result.startTime,result.endTime)}}</td>
                    <td style="text-align:left;">{{result.userAnswer}}</td>
                </tr>
            </table>
            <br />
            <table class="results">
                <tr>
                    <td>Арифметический субтест</td>
                    <td>Верно</td>
                    <td>Время</td>
                </tr>
                <tr v-for="result in results.r3">
                    <td style="text-align: left; vertical-align: top;">{{result.officialNumber}}.&nbsp;{{result.title}}</td>
                    <td>{{result.isRight}}</td>
                    <td style="vertical-align: top;">{{difTime(result.startTime,result.endTime)}}</td>
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
            difTime(startTime, endTime) {
                let dif = new Date(endTime) - new Date(startTime)

                var seconds = Math.floor((dif / 1000) % 60),
                    minutes = Math.floor((dif / (1000 * 60)) % 60),
                    hours = Math.floor((dif / (1000 * 60 * 60)) % 24);

                hours = (hours < 10) ? "0" + hours : hours;
                minutes = (minutes < 10) ? "0" + minutes : minutes;
                seconds = (seconds < 10) ? "0" + seconds : seconds;

                return hours + ":" + minutes + ":" + seconds;
            },

            loadPage() {
                this.loaded = false
                this.$http
                    .get(this.$store.state.baseUrl + `api/result/getUserResults?iteration=` + this.iteration)
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
    table.results {
        width: 100%;
    }
    table.results, .results th, .results td {
        border: 1px solid black;
        border-collapse: collapse;
    }
    .results td {
        padding: 5px 10px;
    }
</style>