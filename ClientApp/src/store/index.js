import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
    state: {
        baseUrl: document.location.href.slice(0, document.location.href.indexOf('#', 0)),
        rightsList:[],
        allRights: [],
        pernr: '',
        doljCode: '',
        reloadYearReservistList: false,

        snackbarShow: false,
        snackbarColor: "#4caf50",
        snackbarText: "",

        userTypes: [
            {
                'title': 'Я',
                'login': ''
            },
            {
                'title': 'Админ Кузнецов',
                'login': 'n.u.kuznetsov'
            },
            {
                'title': 'Борозняк',
                'login': 'i.s.boroznjak'
            },
            {
                'title': 'Кривошеев',
                'login': 'a.n.krivosheev'
            },
            {
                'title': 'Корякин',
                'login': 'a.u.koryakin'
            },
            {
                'title': 'Дикамов',
                'login': 'd.v.dikamov'
            },
            {
                'title': 'Слободянюк',
                'login': 'l.n.slobodyanyuk'
            },
            {
                'title': 'Чубукин',
                'login': 'a.g.chubukin'
            },
            {
                'title': 'Алексеев',
                'login': 's.v.alekseev'
            },
            {
                'title': 'Исмагилов',
                'login': 'r.n.ismagilov'
            },
            {
                'title': 'Сопнев',
                'login': 't.v.sopnev'
            },
            {
                'title': 'Кобычев',
                'login': 'v.f.kobychev'
            },
            {
                'title': 'Воронов',
                'login': 'a.v.voronov'
            },
            {
                'title': 'Маклаков',
                'login': 's.n.maklakov'
            },
            {
                'title': 'Игнатов',
                'login': 'i.v.ignatov'
            },
            {
                'title': 'Апанасенко',
                'login': 'd.m.apanasenko'
            }
        ],
        changedUser: '',
    },
})
