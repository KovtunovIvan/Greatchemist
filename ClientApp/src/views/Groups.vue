<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/`)">Назад</button>
        <div class="customInf" style="max-height: 600px;">
            <p class="customTitle">Группы</p>
            <div v-if="!loaded" class="text-center">
                <v-progress-circular indeterminate
                                     color="#000"
                                     :size="70"></v-progress-circular>
            </div>
            
            <v-text-field v-model.trim="newGroup"
                            label="Новая группа"
                            dark
                            rounded
                            background-color="rgba(88, 74, 74, 0.8)"
                            filled
                            v-if="loaded"
                            append-icon='mdi-plus-circle'
                          @click:append="addGroup"></v-text-field>
            <v-simple-table v-if="loaded" dense style="max-height: 70%; overflow-y: auto;">
                <template v-slot:default>
                    <tbody>
                        <tr v-for="group in groups" :key="group.id" v-if="!group.deleted">
                            <td>{{ group.title }}</td>
                            <td>
                                <v-btn icon
                                        @click="deleteGroup(group)">
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
        name: 'Groups',
        data: () => ({
            loaded: false,
            groups: null,
            newGroup: null,
        }),

        methods: {
            addGroup() {
                if (this.newGroup && this.newGroup.length > 0) {
                    let group = {
                        Email: this.$store.state.email,
                        Title: this.newGroup,
                        Delete: false,
                    }
                    this.$http.post(this.$store.state.baseUrl + `api/group/AddGroup`, group)
                        .then(response => {
                            this.groups.push(response.data)
                            this.newGroup = null
                        })
                        .catch(error => {
                            this.$store.state.snackbarShow = false
                            this.$store.state.snackbarColor = "#ff5252"
                            this.$store.state.snackbarText = "Ошибка удаления"
                            this.$store.state.snackbarShow = true
                            console.log(error)
                        });
                }
            },
            getGroups() {
                this.$http
                    .get(this.$store.state.baseUrl + `api/group/getTeacherGroups?email=` + this.$store.state.email)
                    .then(response => {
                        this.groups = response.data
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

            loadPage() {
                this.loaded = false
                if (!this.$store.state.isTeacher) {
                    this.$store.state.snackbarShow = false
                    this.$store.state.snackbarColor = "#ff5252"
                    this.$store.state.snackbarText = "У Вас нет прав на данную страницу"
                    this.$store.state.snackbarShow = true
                    this.$router.push({ path: '/' })
                } else {
                    this.getGroups()
                }
            },

            deleteGroup(group) {
                if (confirm("Удалить группу? Автоматически будут удалены пользователи этой группы")) {
                    group.deleted = true
                    this.$http.post(this.$store.state.baseUrl + `api/group/DeleteGroup`, group)
                        .then(response => { })
                        .catch(error => {
                            this.$store.state.snackbarShow = false
                            this.$store.state.snackbarColor = "#ff5252"
                            this.$store.state.snackbarText = "Ошибка удаления"
                            this.$store.state.snackbarShow = true
                            console.log(error)
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
    .inputWrap .v-messages.theme--light {
        display: none;
    }
</style>