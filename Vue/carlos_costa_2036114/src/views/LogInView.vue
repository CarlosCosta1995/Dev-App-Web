<template>
  <!-- partial:index.partial.html -->
  <div class="login-page">
    <div class="form">
      <form class="login-form acrylic"  @submit.prevent="signInRequest">
        <span>Login to your account</span>
        <input
          id="email"
          type="email"
          placeholder="Email"
          v-model="Email"
          required
        />
        <input
          id="pw"
          type="password"
          placeholder="Password"
          v-model="Password"
          required
          minlength="6"
          maxlength="20"
        />
        <button id="SignIn" @click="validateLoginInputs()">Go</button>
        <p class="message">
          <router-link to="/signUp">
            <a>Create Account</a>
          </router-link>
        </p>
        <p class="message">
          <router-link to="/">
            <a>Back</a>
          </router-link>
        </p>
      </form>
    </div>

    <!-- BB-8 Animation -->
    <div class="tattoine">
      <div class="bb-8">
        <div class="head">
          <div class="eye"></div>
        </div>
        <div class="ball">
          <div class="connect one"></div>
          <div class="connect two"></div>
          <div class="connect three"></div>
          <div class="ball__inner one">
            <div class="inside"></div>
          </div>
          <div class="ball__inner two">
            <div class="inside"></div>
          </div>
          <div class="ball__inner three">
            <div class="inside"></div>
          </div>
        </div>
      </div>
      <div class="bb-8--shadow"></div>
      <div class="bb-8--shadow--2"></div>
      <div class="land"></div>
    </div>
  </div>
</template>

<script setup>
import firebase from "firebase";
import "firebase/firestore";
import "firebase/auth";

export default {
  name: "SignIn",
  data: function () {
    return {
      Email: "",
      Password: "",
      PasswordConfirm: "",
      errorMessage: '',
    };
  },
  methods: {
    signInRequest() {
      firebase
        .auth()
        .signInWithEmailAndPassword(this.Email, this.Password)
        .then(
          (user) => {
            console.log(user);
            console.log("LogIn Successfully");
            this.$router.push("/admin"); // redirect AdminPage
          },
          (error) => {
            console.log(error);
            console.log(this.error);
          }
        );
    },
    validateLoginInputs() {
      if (
        // Ignore the \. error
        // eslint-disable-next-line
        !/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(this.Email)
      ) {
        console.log("aqui1");
        this.errorMessage = "Invalid Email address.";
      } else if (this.Password.length < 6) {
        console.log("aqui2");
        this.errorMessage = "Password must contain at least 6 characters.";
      } else {
        console.log("aqui3");
        this.signInRequest();
      }
    },
  },
};
</script>

<style scoped>
@import "@/assets/css/LogInView.css";
</style>
