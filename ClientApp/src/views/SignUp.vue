<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/`)">Назад</button>
        <div class="customInf">
            <p class="customTitle">Регистрация</p>
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
                            <v-text-field v-model.trim="user.email"
                                          label="E-mail"
                                          dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          filled></v-text-field>
                        </v-col>
                        <v-col cols="12"
                               sm="6"
                               md="6"
                               style=" margin-top: -23px;">
                            <v-text-field v-model.trim="user.password1"
                                          label="Придумайте пароль"
                                          dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
                                          :type="showPassword ? 'text' : 'password'"
                                          @click:append="showPassword = !showPassword"
                                          filled></v-text-field>
                        </v-col>
                        <v-col cols="12"
                               sm="6"
                               md="6"
                               style=" margin-top: -23px;">
                            <v-text-field v-model.trim="user.password2"
                                          label="Повторите пароль"
                                          dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
                                          :type="showPassword ? 'text' : 'password'"
                                          @click:append="showPassword = !showPassword"
                                          filled></v-text-field>
                        </v-col>
                        <v-col cols="12"
                               sm="6"
                               md="6"
                               style=" margin-top: -23px;">
                            <v-select v-model="user.group"
                                      label="Группа"
                                      :items="groups"
                                      item-text="title"
                                      item-value="id"
                                      dark
                                      rounded
                                      background-color="rgba(88, 74, 74, 0.8)"
                                      filled></v-select>
                        </v-col>
                        <v-col cols="12"
                               sm="6"
                               md="6"
                               style=" margin-top: -23px;">
                            <v-select v-model="user.hand"
                                      label="Преобладающая рука"
                                      :items="hands"
                                      item-text="title"
                                      item-value="id"
                                      dark
                                      rounded
                                      background-color="rgba(88, 74, 74, 0.8)"
                                      filled></v-select>
                        </v-col>
                        <v-col cols="12"
                               sm="8"
                               md="8"
                               style=" margin-top: -23px;">
                            <v-text-field v-model.trim="user.name"
                                          label="Фамилия, имя и отчество"
                                          dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          filled></v-text-field>
                        </v-col>
                        <v-col cols="12"
                               sm="4"
                               md="4"
                               style=" margin-top: -23px;">
                            <v-menu v-model="menu2"
                                    :close-on-content-click="false"
                                    :nudge-right="40"
                                    transition="scale-transition"
                                    offset-y
                                    min-width="auto">
                                <template v-slot:activator="{ on, attrs }">
                                    <v-text-field id="dateOfInstall"
                                                  v-model="computedDateFormatted"
                                                  readonly
                                                  v-bind="attrs"
                                                  v-on="on"
                                                  label="Дата рождения"
                                                  dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          filled></v-text-field>
                                </template>
                                <v-date-picker v-model="user.birthday"
                                               :first-day-of-week="1"
                                               locale="ru-RU"
                                               @input="menu2 = false">
                                </v-date-picker>
                            </v-menu>
                        </v-col>
                        <v-col cols="12"
                               sm="12"
                               md="12"
                               style=" margin-top: -23px;">
                            <v-text-field v-model.trim="user.note"
                                          label="Примечание"
                                          dark
                                          rounded
                                          background-color="rgba(88, 74, 74, 0.8)"
                                          filled></v-text-field>

                        </v-col>
                        <div style="text-align: center; width: 100%;">
                            <v-btn rounded
                                   color="rgba(30, 29, 29, 0.8)"
                                   dark
                                   x-large
                                   @click="addUser()">
                                Зарегистрироваться
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
        name: 'SignUp',
        data: () => ({
            menu2: false,

            showPassword: false,
            hands: [
                {
                    'id': 0,
                    'title': 'Правша'
                },
                {
                    'id': 1,
                    'title': 'Левша'
                }
            ],
            groups: null,
            user: {
                'email': null,
                'password1': null,
                'password2': null,
                'group': null,
                'hand': 0,
                'name': null,
                'birthday': null,
                'note':null,
            },
            loaded: false,
        }),

        computed: {
            computedDateFormatted() {
                return this.formatDate(this.user.birthday)
            },
        },

        methods: {
            formatDate(date) {
                if (!date) return null

                const [year, month, day] = date.split('-')
                return `${day}.${month}.${year}`
            },

            getGroups() {
                this.$http
                    .get(this.$store.state.baseUrl + `api/group/GetGroups`)
                    .then(response => {
                        this.groups = response.data
                        this.user.group = this.groups[0].id
                        this.loaded = true
                    })
                    .catch(e => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка загрузки групп"
                        this.$store.state.snackbarShow = true

                        console.log(e)
                    });
            },

            addUser() {
                if (!this.user.email || this.user.email.length == 0 || !this.user.password1 || this.user.password1.length == 0 || !this.user.password2 || this.user.password2.length == 0 || !this.user.name || this.user.name.length == 0 || !this.user.birthday || this.user.birthday.length == 0 ) {
                    alert("Все поля, кроме примечания, обязательны для заполнения")
                } else if (this.user.password1 != this.user.password2) {
                    alert("Пароли не совпадают")
                } else {
                    this.loaded = false
                    let a = new Date()
                    let user = {
                        Email: this.user.email,
                        Password: this.user.password1,
                        Name: this.user.name,
                        GroupId: this.user.group,
                        MainHand: this.user.hand ? true : false,
                        BirthDay: a.toJSON(),
                        AdditionalInf: this.user.note,
                        Deleted: false,
                    }
                    this.$http.post(this.$store.state.baseUrl + `api/user/AddUser`, user)
                        .then(response => {
                            this.$store.state.snackbarShow = false
                            this.$store.state.snackbarColor = "#4caf50"
                            this.$store.state.snackbarText = "Вы успешно зарегистрированы"
                            this.$store.state.snackbarShow = true
                            this.$router.push({ path: '/SignIn/' })
                        })
                        .catch(error => {
                            this.$store.state.snackbarShow = false
                            this.$store.state.snackbarColor = "#ff5252"
                            this.$store.state.snackbarText = "Ошибка регистрации"
                            this.$store.state.snackbarShow = true
                            this.loadedTag = true
                            console.log(error)
                        })
                        .finally(() => {
                            this.loaded = true
                        });
                }
            },

            loadPage() {
                this.loaded = false
                this.getGroups()
            },
        },

        created() {
            this.loadPage()
        },
    };
</script>