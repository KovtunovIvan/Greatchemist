<template>
    <div style="height:100%;">
        <div v-if="!loaded" class="text-center">
            <v-progress-circular indeterminate
                                 color="#000"
                                 :size="70"></v-progress-circular>
        </div>
        <div style="position: relative;height:100%;" v-if="loaded && isTesting">
            <img :src="`../assets/images/` + question.questionLink" style="max-width: 100%; max-height: 80%;" />
            <div class="answerButtonsWrap">
                <v-container>
                    <v-row>
                        <v-col cols="12"
                               sm="6"
                               md="6">
                            <v-btn x-large
                                   color="#FFC702"
                                   class="answerButton"
                                   @click="addAnswer(1)"
                                   style="width:100%;">
                                {{question.btn1}}
                            </v-btn>
                        </v-col>
                        <v-col cols="12"
                               sm="6"
                               md="6">
                            <v-btn x-large
                                   color="#FFC702"
                                   class="answerButton"
                                   @click="addAnswer(2)"
                                   style="width:100%;">
                                {{question.btn2}}
                            </v-btn>
                        </v-col>
                    </v-row>
                </v-container>
            </div>
        </div>
        <div style="position: relative;height:100%;" v-if="loaded && !isTesting">
            <p class="testText">Вы успешно завершили задание {{officialNumber}}</p>
            <p class="testText">Ваш резутат: {{rightCount}} из {{commonCount}}</p>
            <p class="testText">Затраченное время: {{timeFunc}}</p>
            <div class="answerButtonsWrap">
                <v-btn x-large
                       color="#FFC702"
                       class="answerButton"
                       @click="restart()">
                    Продолжить
                </v-btn>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'TaskType1',

        props: {
            questions: {
                type: Array,
                required: true
            },
            iterationId: {
                type: Number,
                required: true
            },
            officialNumber: {
                type: String,
                required: true
            },
        },

        data: () => ({
            id: 0,
            question: null,
            startTime: new Date(),
            endTime: new Date(),
            isTesting: false,
            commonCount: 0,
            rightCount: 0,
            loaded: false,
        }),

        computed: {
            timeFunc: function () {
                let dif = this.endTime - this.startTime

                var seconds = Math.floor((dif / 1000) % 60),
                    minutes = Math.floor((dif / (1000 * 60)) % 60),
                    hours = Math.floor((dif / (1000 * 60 * 60)) % 24);

                hours = (hours < 10) ? "0" + hours : hours;
                minutes = (minutes < 10) ? "0" + minutes : minutes;
                seconds = (seconds < 10) ? "0" + seconds : seconds;

                return hours + ":" + minutes + ":" + seconds;
            }
        },

        methods: {
            loadPage() {
                this.id = 0
                this.question = this.questions[this.id]
                this.$store.state.answers = []
                this.startTime = new Date()
                this.isTesting = true
                this.loaded = true
            },

            restart() {
                if (this.$store.state.parallel == 2) {
                    this.$emit("testEnded")
                } else {
                    this.$store.state.parallel = this.$store.state.parallel + 1
                    this.loadPage()
                }
            },

            addAnswer(number) {
                let a = {
                    QuestionId: this.question.id,
                    UserAnswer: number,
                    IterationId: this.iterationId,
                    Parallel: this.$store.state.parallel
                }
                this.$store.state.answers.push(a)
                if (this.id < this.questions.length - 1) {
                    this.id++
                    this.question = this.questions[this.id]
                } else {
                    this.isTesting = false
                    this.loaded = false
                    this.endTime = new Date()

                    let res = {
                        startTime: this.startTime,
                        endTime: this.endTime,
                        answers: this.$store.state.answers,
                        task: this.$store.state.currentTask
                    }

                    this.$http
                        .post(this.$store.state.baseUrl + `api/test/addAnswersType1`, res)
                        .then(response => {
                            this.commonCount = this.$store.state.answers.length
                            this.rightCount = response.data
                            this.loaded = true
                        })
                        .catch(e => {
                            this.$store.state.snackbarShow = false
                            this.$store.state.snackbarColor = "#ff5252"
                            this.$store.state.snackbarText = "Ошибка сохранения ответов"
                            this.$store.state.snackbarShow = true
                            this.$router.push({ path: '/' })

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

<style>
    .answerButtonsWrap {
        position: absolute;
        bottom: 0px;
        width: 100%;
        display: flex;
        justify-content: center;
    }

    .answerButton {
        display: block;
        font-weight: 900;
        margin: 0 10px;
    }

    .testText{
        font-size: 20px;
    }
</style>

