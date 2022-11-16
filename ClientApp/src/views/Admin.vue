<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/`)">Назад</button>
        <div class="customInf" style="max-height: 600px;">
            <p class="customTitle">Администрирование</p>
            <div v-if="!loaded" class="text-center">
                <v-progress-circular indeterminate
                                     color="#000"
                                     :size="70"></v-progress-circular>
            </div>
            <v-simple-table v-else dense style="max-height: 80%; overflow-y: auto;">
                <template v-slot:default>
                    <thead>
                        <tr>
                            <th class="text-left">E-mail</th>
                            <th class="text-left">Имя</th>
                            <th class="text-left">Преподаватель</th>
                            <th class="text-left">Менеджер</th>
                            <th class="text-left"></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="user in users" :key="user.id" v-if="!user.deleted">
                            <td>{{ user.email }}</td>
                            <td>{{ user.name }}</td>
                            <td class="inputWrap">
                                <v-checkbox v-model="user.isTeacher"
                                            dense
                                            @click="changeUser(user)"></v-checkbox>
                            </td>
                            <td class="inputWrap">
                                <v-checkbox v-model="user.isManager"
                                            dense
                                            @click="changeUser(user)"></v-checkbox>
                            </td>
                            <td>
                                <v-btn icon
                                       @click="deleteUser(user)">
                                    <v-icon>mdi-delete</v-icon>
                                </v-btn>
                            </td>
                        </tr>
                    </tbody>
                </template>
            </v-simple-table>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Admin',
        data: () => ({
            loaded: false,
            users: null,
        }),

        methods: {
            getUsers() {
                this.$http
                    .get(this.$store.state.baseUrl + `api/user/getUsers`)
                    .then(response => {
                        this.users = response.data
                        this.loaded = true
                    })
                    .catch(e => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка загрузки пользователей"
                        this.$store.state.snackbarShow = true

                        console.log(e)
                    });
            },

            loadPage() {
                this.loaded = false
                if (!this.$store.state.isManager) {
                    this.$store.state.snackbarShow = false
                    this.$store.state.snackbarColor = "#ff5252"
                    this.$store.state.snackbarText = "У Вас нет прав на данную страницу"
                    this.$store.state.snackbarShow = true
                    this.$router.push({ path: '/' })
                } else {
                    this.getUsers()
                }
            },

            deleteUser(user) {
                if (confirm("Удалить пользователя?")) {
                    user.deleted = true
                    this.changeUser(user)
                }
            },

            changeUser(user) {
                this.$http.post(this.$store.state.baseUrl + `api/user/ChangeUser`, user)
                    .then(response => {})
                    .catch(error => {
                        this.$store.state.snackbarShow = false
                        this.$store.state.snackbarColor = "#ff5252"
                        this.$store.state.snackbarText = "Ошибка внесения изменений"
                        this.$store.state.snackbarShow = true
                        console.log(error)
                    });
            }
        },

        created() {
            this.loadPage()
        },
    };
</script>

<style>
    .inputWrap .v-messages.theme--light {
        display: none;
    }
</style>