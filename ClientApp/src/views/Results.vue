<template>
    <div class="buttonsWrap">
        <button class="customBtn" @click="$router.push(`/`)">Назад</button>
        <div class="customInf">
            <p class="customTitle">Результаты</p>
            <p class="customP">
                Сайт реализует методику скоростной классификации стимул-объектов. Автор методики – доктор психологических наук Волкова Е.В.
            </p>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Results',
        data: () => ({}),

        methods: {
            loadPage() {},
        },

        created() {
            this.loadPage()
        },
    };
</script>