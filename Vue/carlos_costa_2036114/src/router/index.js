import Vue from 'vue'
import VueRouter from 'vue-router'
import HomeView from '../views/HomeView.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/home',
    name: 'home',
    component: HomeView,
    meta: {
      navBar: true,
      footerBar: true,
    }
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue'),
    meta: {
      navBar: true,
      footerBar: true,
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
  }
]

const router = new VueRouter({
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