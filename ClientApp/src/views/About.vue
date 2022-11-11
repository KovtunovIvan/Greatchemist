<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/`)">Назад</button>
        <div class="customInf">
            <p class="customTitle">О сайте</p>
            <p class="customP">
                Сайт реализует методику скоростной классификации стимул-объектов. Автор методики – доктор психологических наук Волкова Е.В.
            </p>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'About',
        data: () => ({}),

        methods: {
            loadPage() {},
        },

        created() {
            this.loadPage()
        },
    };
</script>

<style>
    .customInf {
        background: rgba(235,255,3,0.5);
        border-radius: 26px;
        width: 901px;
        max-width: 90%;
        margin-bottom: 5%;
        margin-left: 5%;
        box-sizing: border-box;
        padding: 3% 5% 5%;
        text-align: center;
    }

    .customTitle {
        font-size: 6vh;
        font-family: ResphektRegular;
    }

    .customP {
        font-size: 3vh;
        font-family: Arial, "Nimbus Sans L", Helvetica, sans-serif;
        margin-top:20px;
    }
</style>