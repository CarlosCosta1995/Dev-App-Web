import Vue from 'vue'
import VueRouter from 'vue-router'
import HomeView from '../views/HomeView.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView,
    meta: {
      navBar: true,
      footerBar: true,
    }
  },
  {
    path: '/admin',
    name: 'admin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AdminView.vue'),
    meta: {
      navBar: false,
      footerBar: false,
    }
  },
  {
    path: '/solarSystem',
    name: 'solarSystem',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "solarSystem" */ '../views/SolarSystemView.vue'),
    meta: {
      navBar: true,
      footerBar: false,
    }
  },
  {
    path: '/page404',
    name: 'page404',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    // https://stackoverflow.com/questions/58615754/how-to-hide-global-component-e-g-navbar-on-some-routes
    component: () => import(/* webpackChunkName: "page404" */ '../views/Page404View.vue'),
    meta: {
      navBar: false,
      footerBar: false,
    }
  },
  {
    path: '/logIn',
    name: 'logIn',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    // https://stackoverflow.com/questions/58615754/how-to-hide-global-component-e-g-navbar-on-some-routes
    component: () => import(/* webpackChunkName: "page404" */ '../views/LogInView.vue'),
    meta: {
      navBar: false,
      footerBar: false,
    }
  },
  {
    path: '/signUp',
    name: 'signUp',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    // https://stackoverflow.com/questions/58615754/how-to-hide-global-component-e-g-navbar-on-some-routes
    component: () => import(/* webpackChunkName: "page404" */ '../views/SignUpView.vue'),
    meta: {
      navBar: false,
      footerBar: false,
    }
  },
  {
    path: '/timeLine',
    name: 'timeLine',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    // https://stackoverflow.com/questions/58615754/how-to-hide-global-component-e-g-navbar-on-some-routes
    component: () => import(/* webpackChunkName: "page404" */ '../views/TimeLineView.vue'),
    meta: {
      navBar: true,
      footerBar: true,
    }
  }
]

const router = new VueRouter({
  mode: 'history',
  routes
})

export default router

import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'

// Import Bootstrap an BootstrapVue CSS files (order is important)
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

// Make BootstrapVue available throughout your project
Vue.use(BootstrapVue)
// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin)