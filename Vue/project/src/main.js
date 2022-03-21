/* eslint-disable */

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import firebase from 'firebase/app';

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyBd7T3GSM5hIIXRpk2VF2tDT8rXGfJwZnA",
  authDomain: "projectvue20.firebaseapp.com",
  projectId: "projectvue20",
  storageBucket: "projectvue20.appspot.com",
  messagingSenderId: "755881820482",
  appId: "1:755881820482:web:37c81e2d465691bbbf48db"
};

// Initialize Firebase
firebase.initializeApp(firebaseConfig);


createApp(App).use(router).mount('#app')
