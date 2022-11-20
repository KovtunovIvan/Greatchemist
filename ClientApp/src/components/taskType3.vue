<template>
    <div>
        <div v-if="!loaded" class="text-center">
            <v-progress-circular indeterminate
                                 color="#000"
                                 :size="70"></v-progress-circular>
        </div>
        <div style="position: relative;" v-if="loaded && isTesting">
            <div style="flex-direction: column;">
                <div class="gidroksid" style="display: flex;">
                    <p>Гидроксид</p>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(1)">
                        {{question.btn1}}
                    </v-btn>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(2)">
                        {{question.btn2}}
                    </v-btn>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(3)">
                        {{question.btn3}}
                    </v-btn>
                </div>

                <div class="centralPartWrap">
                    <div class="oksid">
                        <p>Оксид</p>
                        <v-btn color="#FFC702"
                               class="answerButton customBtn14"
                               @click="addAnswer(4)">
                            {{question.btn4}}
                        </v-btn>
                        <v-btn color="#FFC702"
                               class="answerButton customBtn14"
                               @click="addAnswer(5)">
                            {{question.btn5}}
                        </v-btn>
                        <v-btn color="#FFC702"
                               class="answerButton customBtn14"
                               @click="addAnswer(6)">
                            {{question.btn6}}
                        </v-btn>
                    </div>

                    <div class="centarlPartWrapImgWrap">
                        <img :src="`${publicPath}images/` + question.questionLink" style="max-width: 100%; max-height: 80%;" />
                    </div>

                    
                    <div class="kislota">
                        <p>Кислота</p>
                        <v-btn color="#FFC702"
                               class="answerButton customBtn14"
                               @click="addAnswer(7)">
                            {{question.btn7}}
                        </v-btn>
                        <v-btn color="#FFC702"
                               class="answerButton customBtn14"
                               @click="addAnswer(8)">
                            {{question.btn8}}
                        </v-btn>
                        <v-btn color="#FFC702"
                               class="answerButton customBtn14"
                               @click="addAnswer(9)">
                            {{question.btn9}}
                        </v-btn>
                    </div>
                </div>

                <div class="sol">
                    <p>Соль</p>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(10)">
                        {{question.btn10}}
                    </v-btn>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(11)">
                        {{question.btn11}}
                    </v-btn>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(12)">
                        {{question.btn12}}
                    </v-btn>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(13)">
                        {{question.btn13}}
                    </v-btn>
                    <v-btn color="#FFC702"
                           class="answerButton customBtn14"
                           @click="addAnswer(14)">
                        {{question.btn14}}
                    </v-btn>
                </div>
            </div>
        </div>
        <div style="position: relative;height:100%;" v-if="loaded && !isTesting">
            <p class="testText">Вы успешно завершили задание {{officialNumber}}</p>
            <p class="testText">Ваш резутат: {{rightCount}} из {{commonCount}}</p>
            <p class="testText">Затраченное время: {{timeFunc}}</p>
            <div style="width: 100%; display: flex; justify-content: center;">
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
        name: 'TaskType3',

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
            publicPath: process.env.BASE_URL,
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
            },
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
                        .post(this.$store.state.baseUrl + `api/test/addAnswersType3`, res)
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
    .gidroksid {
        border: 3px solid #800080;
        padding: 15px;
        padding-bottom: 10px;
        flex-wrap: wrap;
    }
    .gidroksid p{
        color: #800080;
        font-weight:700;
        margin-bottom:5px;
    }
    .oksid {
        border: 3px solid #800000;
        margin: 15px 0;
        padding: 15px;
        padding-bottom: 10px;
        width: 10%;
        min-width: 205px;
    }

        .oksid p {
            color: #800000;
            font-weight: 700;
            margin-bottom: 5px;
        }
    .kislota {
        border: 3px solid #008000;
        margin: 15px 0;
        padding: 15px;
        padding-bottom: 10px;
        width: 10%;
        min-width: 205px;
    }

        .kislota p {
            color: #008000;
            font-weight: 700;
            margin-bottom: 5px;
        }
    .sol {
        border: 3px solid #000080;
        display: flex;
        padding: 15px;
        padding-bottom: 10px;
        flex-wrap: wrap;
    }

        .sol p {
            color: #000080;
            font-weight: 700;
            margin-bottom: 5px;
        }

    .centralPartWrap{
        display:flex;
    }

    .centarlPartWrapImgWrap {
        width: 80%;
    }

    .customBtn14 {
        margin-bottom: 10px !important;
    }

    @media only screen and (max-width: 850px) {
        .centralPartWrap {
            flex-direction: column;
        }

        .oksid, .kislota {
            margin: 5px 0;
            padding: 10px;
            width: 100%;
            min-width: 100%;
            display: flex;
            flex-wrap: wrap;
        }

        .gidroksid, .sol {
            margin: 5px 0;
            padding: 10px;
        }

        .centarlPartWrapImgWrap{
            width:100%;
        }
    }
</style>

