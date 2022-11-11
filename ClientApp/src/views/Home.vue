<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/About`)">О сайте</button>
        <button class="customBtn" @click="$router.push(`/SignUp`)" v-if="$store.state.isAuthorized">Пройти тест</button>
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

    .customBtn {
        background: #EBFF03;
        border: 0px;
        border-radius: 26px;
        height: 85px;
        max-height: 10%;
        margin-bottom: 5%;
        margin-left: 5%;
        width: 345px;
        max-width: 90%;
        font-size: 6vh;
        font-family: ResphektRegular;
        padding-bottom: 15px;
    }
</style>