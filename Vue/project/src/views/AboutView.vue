<template>
  <!-- partial:index.partial.html -->
  <div class="login-page">
    <div class="form">
        <!-- <form class="register-form acrylic">
          <span>Sign Up</span>
          <input type="email" placeholder="Email" required />
          <input type="password" placeholder="Password" required minlength="18"/>
          <button id="SignUp">Go</button>
          <p class="message"><a href="#">I have Account</a></p>
        </form> -->
      <div class="login-form acrylic" action="/">
        <span>Login to your account</span>
        <input id="email" type="email" placeholder="Email" v-model="Email" required/>
        <input id="pw" type="password" placeholder="Password" v-model="Password" required minlength="6" maxlength="20"/>
        <!-- <span v-if="v$.Password.$error">{{ v$.Password.$errors[0].$message }}</span> -->
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
      </div>
    </div>

    <!-- partial:index.partial.html -->
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
      <div class="bb-8--shadow">
        </div>
        <div class="bb-8--shadow--2">
        </div>
      <div class="land">
      </div>
    </div>
  </div>
</template>


<script>
import firebase from "firebase";

export default {
  name: "signUp",
  data() {
    return {
      Email: "",
      Password: "",
    };
  },
  methods: {
    signupRequest() {
      firebase
      .auth()
      .SignInUserWithEmailAndPassword(this.Email, this.Password)
      .then(
        () => {
          this.successMessage= "Register Successfully.";
          console.log(this.successMessage)
          },
        error => {
          let errorResponse= JSON.parse(error.message);
          this.errorMessage= errorResponse.error.message;
          console.log(this.errorMessage)
      });
    }
  }
}
</script>

<style scoped>
@import "@/assets/css/LogInView.css";
</style>