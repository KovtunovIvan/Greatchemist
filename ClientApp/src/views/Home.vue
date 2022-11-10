<template>
    <v-container>
        <v-layout text-center
                  wrap>
            <v-flex xs12>
                <img src="../assets/mainLogo.png" class="mainLogo" />
            </v-flex>

            <v-flex mb-4>
                <h1 class="mb-3 homeTitle">
                    Резерв кадров
                </h1>

                <p class="description">
                    Автоматизированная система
                    <br />формирования и мониторинга резерва кадров
                    <br />ООО «Газпром добыча Уренгой»
                </p>
            </v-flex>
        </v-layout>
    </v-container>
</template>

<script>
    export default {
        name: 'Home',
        data: () => ({}),

        methods: {},

        created() {},
    };
</script>

<style>
    .mainLogo {
        width: 350px;
        margin: 50px 0 30px;
    }

    .homeTitle {
        font-size: 40px;
        line-height: 170%;
        font-family: "helioscond","Segoe UI Light","Segoe UI","Segoe",Tahoma,Helvetica,Arial,sans-serif !important;
        color: rgba(0,0,0,.8);
        font-weight: bold !important;
        margin-bottom: 0 !important;
    }

    .description {
        font: 20px/130% "helioscond","Segoe UI Light","Segoe UI","Segoe",Tahoma,Helvetica,Arial,sans-serif !important;
        color: rgba(0,0,0,.8);
    }

    .mainButton {
        margin-right: 15px;
    }

    /*.homeSubTitle {
        font: 25px/120% "helioscond","Segoe UI Light","Segoe UI","Segoe",Tahoma,Helvetica,Arial,sans-serif !important;
        color: #7f7f7f;
        font-weight: bold !important;
    }

    .subheading {
        font-family: "helioscond","Segoe UI Light","Segoe UI","Segoe",Tahoma,Helvetica,Arial,sans-serif !important;
    }*/

    /*стили дерева*/
    .searchMenu {
        border-bottom: 1px solid #007acd;
        color: #424245;
        font-family: Segoe UI,Tahoma,Arial,Verdana;
        font-size: 15px;
        line-height: 2;
        margin-bottom: 10px;
    }

    .usualSearch {
        cursor: pointer;
        float: left;
        width: 50%;
        white-space: nowrap;
        overflow: hidden;
        text-overflow: ellipsis;
    }

    .extendedSearch {
        cursor: pointer;
        float: right;
        text-align: right;
        width: 50%;
        white-space: nowrap;
        overflow: hidden;
        text-overflow: ellipsis;
    }

    .currentSearchMenu {
        font-weight: 600;
    }

    .treeWrap .v-text-field.v-text-field--enclosed .v-text-field__details, .isUnusualSearch .v-messages.theme--light {
        display: none !important;
    }

    .treeWrap .v-input__slot fieldset {
        background: white;
    }

    .treeWrap .v-input__append-inner {
        z-index: 10 !important;
    }

    .treeNode {
        height: 100%;
        text-decoration: none;
        width: 100%;
        display: inline-block;
    }

    .deletedNode {
        text-decoration: line-through;
    }

    .isSearch {
        font-weight: bold;
    }

    .v-treeview-node__label {
        font-size: 14px !important;
    }

    .v-treeview--dense .v-treeview-node__root {
        min-height: 25px !important;
    }

    .v-treeview-node .v-icon.v-icon {
        font-size: 27px !important;
        color: black !important;
    }

    .v-treeview-node__content {
        background: url(../assets/img/superCorner.png) no-repeat;
        margin-left: -12px !important;
        padding-left: 18px;
        background-position: -3px -7px;
    }

    .v-treeview-node__level {
        background: url(../assets/img/line.png) repeat-y;
        background-position: 9px 0px;
        height: 24px;
    }

    @media all and (-ms-high-contrast: none), (-ms-high-contrast: active) {
        /* IE10+ CSS styles go here */
        .v-treeview-node__content {
            background: url(../assets/img/superCorner.png) no-repeat;
            margin-left: -12px !important;
            padding-left: 18px;
            background-position: -3px -9px;
        }
    }
</style>