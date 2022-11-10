<template>
        <v-snackbar v-model="$store.state.snackbarShow"
                    :bottom=true
                    :color='$store.state.snackbarColor'
                    :multi-line=false
                    :left=true
                    style="font-family: Segoe UI,Roboto,Helvetica Neue,Arial,sans-serif !important;">
            {{$store.state.snackbarText}}
            <template v-slot:action="{ attrs }">
                <v-btn color="pink"
                       text
                       v-bind="attrs"
                       @click="$store.state.snackbarShow = false">
                    X
                </v-btn>
            </template>
        </v-snackbar>
</template>

