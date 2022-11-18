import 'whatwg-fetch'
import '@mdi/font/css/materialdesignicons.css'
import Vue from 'vue'
import App from './App.vue'
import axios from 'axios'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify';

import Snackbar from './components/snackbar.vue'
import DatePicker from './components/datePicker.vue'
import TaskType1 from './components/taskType1.vue'
import TaskType2 from './components/taskType2.vue'
import TaskType3 from './components/taskType3.vue'
import TaskType4 from './components/taskType4.vue'
import TaskType5 from './components/taskType5.vue'
import TaskType6 from './components/taskType6.vue'
import Result from './components/result.vue'

Vue.component('app-snackbar', Snackbar)
Vue.component('app-date-picker', DatePicker)
Vue.component('app-task-type1', TaskType1)
Vue.component('app-task-type2', TaskType2)
Vue.component('app-task-type3', TaskType3)
Vue.component('app-task-type4', TaskType4)
Vue.component('app-task-type5', TaskType5)
Vue.component('app-task-type6', TaskType6)
Vue.component('app-result', Result)

Vue.config.productionTip = false
Vue.prototype.$http = axios

Vue.filter('dateFormat', (value) => {
    if (value) {
        let date = new Date(value);
        let year = date.getFullYear();
        let month = date.getMonth() + 1;
        month = month < 10 ? '0' + month : month;
        let day = date.getDate();
        day = day < 10 ? '0' + day : day;
        let hours = date.getHours();
        hours = (hours < 10) ? "0" + hours : hours;
        let minutes = date.getMinutes();
        minutes = (minutes < 10) ? "0" + minutes : minutes;
        date = day + '.' + month + '.' + year + ' ' + hours + ':' + minutes;
        return date;
    } else {
        return null
    }
})

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')
