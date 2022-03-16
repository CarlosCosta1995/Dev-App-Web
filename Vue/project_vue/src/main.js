import { createApp } from 'vue'
import App from './App.vue'
import router from './router'

import 'bootstrap/dist/css/bootstrap.min.css'
import 'jquery/src/jquery.js'
import 'bootstrap/dist/js/bootstrap.min.js'
import 'bootstrap-icons/font/bootstrap-icons';

// import scriptsJSMain from '@/assets/js/main';
// import scriptsJSLogin from '@/assets/js/logIn';
// import scriptsJS404 from '@/assets/js/page404';
// import scriptsJSSolar from '@/assets/js/solarSystem';
// import scriptsJSTime from '@/assets/js/verticalTimeLine';


createApp(App).use(router).mount('#app')


// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries
// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyA-pSG7QUfcxU5uFar8IYX9Ff8BUJv3QQQ",
  authDomain: "project-vue-cc.firebaseapp.com",
  projectId: "project-vue-cc",
  storageBucket: "project-vue-cc.appspot.com",
  messagingSenderId: "249136196491",
  appId: "1:249136196491:web:5edb383d5e84fa03351d8e",
  measurementId: "G-0CMQ1F3ZJC"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
app;
