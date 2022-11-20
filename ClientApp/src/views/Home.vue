<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/About`)">О сайте</button>
        <button class="customBtn" @click="$router.push(`/Groups`)" v-if="$store.state.isTeacher">Группы</button>
        <button class="customBtn" @click="$router.push(`/Admin`)" v-if="$store.state.isManager">Администрирование</button>
        <button class="customBtn" @click="$router.push(`/TeacherGroups`)" v-if="$store.state.isTeacher">Результаты учеников</button>
        <button class="customBtn" @click="$router.push(`/Results`)" v-if="$store.state.isAuthorized">Мои результаты</button>
        <button class="customBtn" @click="$router.push(`/Test`)" v-if="$store.state.isAuthorized">Пройти тест</button>
        <button class="customBtn" @click="$router.push(`/SignUp`)" v-if="!$store.state.isAuthorized">Регистрация</button>
        <button class="customBtn" @click="$router.push(`/SignIn`)" v-if="!$store.state.isAuthorized">Авторизация</button>
    </div>
</template>

<script>
    export default {
        name: 'Home',
        data: () => ({}),

        methods: {
            loadPage() {
            },
        },

        created() {
            this.loadPage()
        },
    };
</script>

<style>
    .buttonsWrap {
        height: 100%;
        width: 100%;
        display: flex;
        flex-direction: column-reverse;
    }

    @media screen and (orientation: portrait){
        .buttonsWrap {
            padding: 15% 0%;
        }
    }

    .customBtn {
        background: #EBFF03;
        border: 0px;
        border-radius: 26px;
        height: 85px;
        max-height: 10%;
        min-height:55px;
        margin-bottom: 3%;
        margin-left: 5%;
        width: 345px;
        max-width: 90%;
        font-size: 6vh;
        font-family: ResphektRegular;
        padding-bottom: 15px;
    }
</style>