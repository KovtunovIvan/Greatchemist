<template>
    <div class="test">
        <div class="testWrap">
            <div v-if="!loaded" class="text-center">
                <v-progress-circular indeterminate
                                     color="#000"
                                     :size="70"></v-progress-circular>
            </div>
            <div v-if="loaded && !passingTest">
                <p class="testTitle">Задание {{$store.state.currentTask}}</p>
                <p class="testText">{{task.description}}</p>
            </div>

            <app-task-type1 v-if="loaded && passingTest && ($store.state.currentTask == 1 || $store.state.currentTask == 2 || $store.state.currentTask == 3 || $store.state.currentTask == 4 || $store.state.currentTask == 7 || $store.state.currentTask == 9 || $store.state.currentTask == 10 || $store.state.currentTask == 11)"
                            :questions="questions"
                            :iterationId="$store.state.iteration"
                            @testEnded="startNewTask()"
                            :key="$store.state.currentTask"></app-task-type1>

            <app-task-type2 v-if="loaded && passingTest && ($store.state.currentTask == 5)"
                            :questions="questions"
                            :iterationId="$store.state.iteration"
                            @testEnded="startNewTask()"
                            :key="$store.state.currentTask"></app-task-type2>

            <app-task-type3 v-if="loaded && passingTest && ($store.state.currentTask == 6)"
                            :questions="questions"
                            :iterationId="$store.state.iteration"
                            @testEnded="startNewTask()"
                            :key="$store.state.currentTask"></app-task-type3>

            <app-task-type4 v-if="loaded && passingTest && ($store.state.currentTask == 8 || $store.state.currentTask == 12 || $store.state.currentTask == 13)"
                            :questions="questions"
                            :iterationId="$store.state.iteration"
                            @testEnded="startNewTask()"
                            :key="$store.state.currentTask"></app-task-type4>

            <app-task-type5 v-if="loaded && passingTest && ($store.state.currentTask == 14 || $store.state.currentTask == 15)"
                            :questions="questions"
                            :iterationId="$store.state.iteration"
                            @testEnded="startNewTask()"
                            :key="$store.state.currentTask"></app-task-type5>

            <app-task-type6 v-if="loaded && passingTest && ($store.state.currentTask == 16 || $store.state.currentTask == 17)"
                            :questions="questions"
                            :iterationId="$store.state.iteration"
                            @testEnded="startNewTask()"
                            :key="$store.state.currentTask"></app-task-type6>
        </div>
        <div class="testButtonsWrap" v-if="loaded && !passingTest">
            <v-btn x-large
                   color="error"
                   dark
                   style="display:block;"
                   @click="$router.push(`/`)">
                Выйти
            </v-btn>
            <v-btn x-large
                   color="success"
                   dark
                   style="display:block;"
                   @click="getQuestions()">
                Приступить
            </v-btn>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Test',
        data: () => ({
            loaded: false,
            task: null,
            passingTest: false,
            questions: null,
        }),

        methods: {
            startNewTask() {
                this.loaded = false
                this.$store.state.parallel = 1
                this.$store.state.currentTask = this.$store.state.currentTask + 1
                if (this.$store.state.currentTask == 18) {
                    this.endTask()
                } else {
                    this.getTask()
                }
            },

            endTask() {
                this.$store.state.snackbarShow = false
                this.$store.state.snackbarColor = "#4caf50"
                this.$store.state.snackbarText = "Вы успешно прошли тестирование"
                this.$store.state.snackbarShow = true
                this.$router.push({ path: '/Results/' })
            },

            getQuestions() {
                this.loaded = false
                let db = ''
                let count = 0
                switch (this.$store.state.currentTask) {
                    case 1:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 2:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 3:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 4:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 5:
                        db = 'GetQuestionsType2'
                        count = 1
                        break
                    case 6:
                        db = 'GetQuestionsType3'
                        count = 1
                        break
                    case 7:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 8:
                        db = 'GetQuestionsType4'
                        count = 1
                        break
                    case 9:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 10:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 11:
                        db = 'GetQuestionsType1'
                        count = 1
                        break
                    case 12:
                        db = 'GetQuestionsType4'
                        count = 1
                        break
                    case 13:
                        db = 'GetQuestionsType4'
                        count = 1
                        break
                    case 14:
                        db = 'GetQuestionsType5'
                        count = 1
                        break
                    case 15:
                        db = 'GetQuestionsType5'
                        count = 1
                        break
                    case 16:
                        db = 'GetQuestionsType6'
                        count = 1
                        break
                    case 17:
                        db = 'GetQuestionsType6'
                        count = 1
                        break
                }

                this.$http
                    .get(this.$store.state.baseUrl + `api/test/` + db + `?task=` + this.$store.state.currentTask + `&count=` + count)
                    .then(response => {
                        this.questions = response.data
                        this.loaded = true
                        this.passingTest = true
                    })
                    .catch(e => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка загрузки вопросов"
                        this.$store.state.snackbarShow = true

                        console.log(e)
                    });
            },

            getTask() {
                this.passingTest = false
                this.$http
                    .get(this.$store.state.baseUrl + `api/test/GetTask?id=` + this.$store.state.currentTask)
                    .then(response => {
                        this.task = response.data
                        this.loaded = true
                    })
                    .catch(e => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка загрузки задания"
                        this.$store.state.snackbarShow = true

                        console.log(e)
                    });
            },

            startTest() {
                let u = {
                    email: this.$store.state.email,
                    password: this.$store.state.password
                }
                this.$http
                    .post(this.$store.state.baseUrl + `api/test/startTest`, u)
                    .then(response => {
                        this.$store.state.iteration = response.data
                        this.$store.state.currentTask = 1
                        this.getTask()
                    })
                    .catch(e => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка"
                        this.$store.state.snackbarShow = true
                        this.$router.push({ path: '/' })

                        console.log(e)
                    });
            },

            loadPage() {
                this.loaded = false
                this.passingTest = false
                if (!this.$store.state.isAuthorized || !this.$store.state.email || this.$store.state.email.length == 0) {
                    this.$store.state.snackbarShow = false
                    this.$store.state.snackbarColor = "#ff5252"
                    this.$store.state.snackbarText = "Необходимо авторизоваться"
                    this.$store.state.snackbarShow = true
                    this.$router.push({ path: '/SignIn' })
                }else if (confirm('Приступить к тестированию?')) {
                    this.startTest()
                } else {
                    this.$router.push({ path: '/' })
                }
            },
        },

        created() {
            this.loadPage()
        },
    };
</script>

<style>
    .test {
        height: 100%;
        overflow: hidden !important;
        width: 100%;
        background-image: url('../assets/bkg3.png');
        background-size: cover;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .testWrap {
        box-sizing: border-box;
        background: white;
        padding: 5%;
        width: 80%;
        height: 50%;
        min-height: 510px;
        border-radius: 26px;
        text-align: center;
    }

    .testTitle {
        font-size: 3vh;
    }

    .testButtonsWrap {
        position: absolute;
        bottom: 0px;
        width: 100%;
        padding: 30px;
        display: flex;
        justify-content: space-between;
    }

    @media only screen and (max-width: 850px) {
        .testWrap {
            height: 70%;
        }
    }
</style>