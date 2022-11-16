<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/`)">Назад</button>
        <div class="customInf">
            <p class="customTitle">Авторизация</p>
            <div v-if="!loaded" class="text-center">
                <v-progress-circular indeterminate
                                     color="#000"
                                     :size="70"></v-progress-circular>
            </div>
            <v-form v-if="loaded">
                <v-container>
                    <v-row>
                        <v-col cols="12"
                               sm="12"
                               md="12">
                            <v-text-field label="E-mail"
                                          filled
                                          dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          v-model.trim="email"></v-text-field>

                            <v-text-field label="Пароль"
                                          dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          filled
                                          :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
                                          :type="showPassword ? 'text' : 'password'"
                                          @click:append="showPassword = !showPassword"
                                          v-model.trim="password"></v-text-field>
                        </v-col>
                        <div style="text-align: center; width: 100%;">
                            <v-btn rounded
                                   color="rgba(30, 29, 29, 0.8)"
                                   dark
                                   x-large
                                   style="margin-right:15px;"
                                   @click="comeIn()">
                                Вход
                            </v-btn>

                            <v-btn rounded
                                   color="rgba(30, 29, 29, 0.8)"
                                   dark
                                   x-large
                                   @click="$router.push(`/SignUp`)">
                                Я новый пользователь
                            </v-btn>
                        </div>
                    </v-row>
                </v-container>
            </v-form>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'SignIn',
        data: () => ({
                email: null,
                password: null,
            showPassword: false,
            loaded: true,
        }),

        methods: {
            comeIn() {
                if (!this.email || this.email.length == 0 || !this.password || this.password.length == 0) {
                    alert("Все поля обязательны для заполнения")
                } else {
                    this.loaded = false
                    let u = {
                        email: this.email,
                        password: this.password
                    }
                    this.$http
                        .post(this.$store.state.baseUrl + `api/user/authorization`, u)
                        .then(response => {
                            if (this.$store.state.email != this.email) {
                                this.$store.state.email = this.email
                            }
                            if (this.$store.state.password != this.password) {
                                this.$store.state.password = this.password
                            }
                            if (this.$store.state.isAuthorized != response.data.isAuthorized) {
                                this.$store.state.isAuthorized = response.data.isAuthorized
                            }
                            if (this.$store.state.isTeacher != response.data.isTeacher) {
                                this.$store.state.isTeacher = response.data.isTeacher
                            }
                            if (this.$store.state.isManager != response.data.isManager) {
                                this.$store.state.isManager = response.data.isManager
                            }

                            if (!response.data.isAuthorized) {
                                this.$store.state.snackbarShow = false
                                this.$store.state.snackbarColor = "#ff5252"
                                this.$store.state.snackbarText = "Введены неверные e-mail или пароль"
                                this.$store.state.snackbarShow = true
                            } else {
                                this.$router.push({ path: '/' })
                            }
                            this.loaded = true
                        })
                        .catch(e => {
                            this.$store.state.snackbarShow = false
                            this.$store.state.snackbarColor = "#ff5252"
                            this.$store.state.snackbarText = "Ошибка авторизации"
                            this.$store.state.snackbarShow = true

                            console.log(e)
                        });
                }
            },
            loadPage() {},
        },

        created() {
            this.loadPage()
        },
    };
</script>