<template>
  <!-- partial:index.partial.html -->
  <div class="login-page">
    <div class="form">
        <form class="register-form acrylic">
          <span>Create a new account</span>
          <input type="Email" placeholder="Email" name="Email" v-model="Email"/>
          <input type="Password" placeholder="Password" name="Password" v-model="Password" required minlength="6" maxlength="20"/>
          <input type="Password" placeholder="Password Confirm" v-model="PasswordConfirm" required minlength="6" maxlength="20"/>
          <!-- <span v-if="v$.PasswordConfirm.$error">{{ v$.PasswordConfirm.$errors[0].$message }}</span> -->
          <button id="SignUp" v-on:click="signupRequest">Go</button>
          <p class="message">
            <router-link to="/logIn">
              <a>I have Account</a>
            </router-link>
          </p>
          <p class="message">
            <router-link to="/">
              <a>Back</a>
            </router-link>
          </p>
        </form>
      <!-- <form class="login-form acrylic" action="../../index.html">
        <span>Login to your account</span>
        <input id="Email" type="Email" placeholder="Email" required/>
        <input id="pw" type="Password" placeholder="Password" required minlength="4" maxlength="20"/>
        <input type="submit" value="Submit" id="SignIn" />
        <p class="message"><a href="#">Create Account</a></p>
      </form> -->
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
      .createUserWithEmailAndPassword(this.Email, this.Password)
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