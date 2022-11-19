import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import About from '../views/About.vue'
import Admin from '../views/Admin.vue'
import Groups from '../views/Groups.vue'
import Results from '../views/Results.vue'
import TeacherGroups from '../views/TeacherGroups.vue'
import SignIn from '../views/SignIn.vue'
import SignUp from '../views/SignUp.vue'
import Test from '../views/Test.vue'

Vue.use(VueRouter)

const routes = [
    {
        path: '/',
        name: 'Home',
        component: Home
    },
    {
        path: '/about',
        name: 'About',
        component: About
    },
    {
        path: '/admin',
        name: 'Admin',
        component: Admin
    },
    {
        path: '/groups',
        name: 'Groups',
        component: Groups
    },
    {
        path: '/results',
        name: 'Results',
        component: Results
    },
    {
        path: '/teacherGroups',
        name: 'TeacherGroups',
        component: TeacherGroups
    },
    {
        path: '/signIn',
        name: 'SignIn',
        component: SignIn
    },
    {
        path: '/signUp',
        name: 'SignUp',
        component: SignUp
    },
    {
        path: '/test',
        name: 'Test',
        component: Test
    },
]

const router = new VueRouter({
  routes
})

export default router
