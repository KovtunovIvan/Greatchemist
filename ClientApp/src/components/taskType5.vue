<template>
    <div style="height:100%;">
        <div v-if="!loaded" class="text-center">
            <v-progress-circular indeterminate
                                 color="#000"
                                 :size="70"></v-progress-circular>
        </div>
        <div style="position: relative;height:100%;" v-if="loaded && isTesting">
            <img :src="`../images/` + question.questionLink" style="max-width: 100%; max-height: 80%;" />
            
            <div class="answerButtonsWrap">
                <v-btn x-large
                       color="#FFC702"
                       class="answerButton"
                       @click="addAnswer()">
                    Завершить
                </v-btn>
            </div>
        </div>
        <div style="position: relative;height:100%;" v-if="loaded && !isTesting">
            <p class="testText">Вы успешно завершили задание {{$store.state.currentTask}}</p>
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
        name: 'TaskType5',

        props: {
            questions: {
                type: Array,
                required: true
            },
            iterationId: {
                type: Number,
                required: true
            },
        },

        data: () => ({
            id: 0,
            question: null,
            startTime: new Date(),
            endTime: new Date(),
            isTesting: false,
            loaded: false,

            timer: 0,
            time: 0,
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
                if (this.$store.state.currentTask == 14) {
                    this.time = 600000
                } else if (this.$store.state.currentTask == 15) {
                    this.time = 1200000
                }
                this.loaded = true

                this.countdown();
                
            },

            countdown() {
                this.time--;
                if (this.time < 0) {
                    this.addAnswer()
                }
                else {
                    this.timer = setTimeout(this.countdown, 1000);
                }
            },

            restart() {
                if (this.$store.state.parallel == 1) {
                    this.$emit("testEnded")
                } else {
                    this.$store.state.parallel = this.$store.state.parallel + 1
                    this.loadPage()
                }
            },

            addAnswer() {
                this.isTesting = false
                this.loaded = false
                this.endTime = new Date()

                let res = {
                    startTime: this.startTime,
                    endTime: this.endTime,
                    task: this.$store.state.currentTask,
                    iterationId: this.iterationId,
                    parallel: 1,
                }

                this.$http
                    .post(this.$store.state.baseUrl + `api/test/addAnswersType5`, res)
                    .then(response => {
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
            },
        },

        created() {
            this.loadPage()
        },
    };
</script>
