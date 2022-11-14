import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
    state: {
        baseUrl: document.location.href.slice(0, document.location.href.indexOf('#', 0)),
        
        snackbarShow: false,
        snackbarColor: "#4caf50",
        snackbarText: "",
        email: null,
        password: null,
        isAuthorized: false,
        isAdmin: false,
        iteration: 0,
        currentTask: 0,

        answers: [],
        parallel: 1,
    },
})
