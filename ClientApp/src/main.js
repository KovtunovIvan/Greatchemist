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

Vue.component('app-snackbar', Snackbar)
Vue.component('app-date-picker', DatePicker)
Vue.component('app-task-type1', TaskType1)
Vue.component('app-task-type2', TaskType2)
Vue.component('app-task-type3', TaskType3)
Vue.component('app-task-type4', TaskType4)
Vue.component('app-task-type5', TaskType5)

Vue.config.productionTip = false
Vue.prototype.$http = axios

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')
