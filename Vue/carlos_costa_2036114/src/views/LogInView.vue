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
      <form class="login-form acrylic" action="../../index.html">
        <span>Login to your account</span>
        <input id="email" type="email" placeholder="Email" v-model="Email" required/>
        <input id="pw" type="password" placeholder="Password" v-model="Password" required minlength="6" maxlength="20"/>
        <span v-if="v$.Password.$error">{{ v$.Password.$errors[0].$message }}</span>
        <button id="SignIn" @click="signInRequest()">Go</button>
        <p class="message">
          <router-link to="/signUp">
            <a>Create Account</a>
          </router-link>
        </p>
      </form>
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
import useValidate from "@vuelidate/core";
import { required } from "@vuelidate/validators";
import firebase from "firebase";

export default {
  name: "SignUp",
  data() {
    return {
      v$: useValidate(),
      Email: "",
      Password: "",
      PasswordConfirm: "",
    };
  },
  validations() {
    return {
      Email: {required},
      Password: {required},
      PasswordConfirm: {required},
    }
  },
  methods: {
    submitForm() {
      this.v$.$validate() // checks all inputs
      if (!this.v$.$error) { // if ANY fail validation
        alert('Form successfully submitted.');
        this.signupRequest();
        this.$router.push('/admin');
      } else {
        alert('Form failed validation');
        this.$router.push('/logIn');
      }
    },
    signInRequest() {
      firebase
      .auth()
      .signInWithEmailAndPassword(this.Email, this.Password)
      .then ( 
        () => {
          this.sucessMessage = "Register Successfully.";
        },
        error => {
          let errorResponse = JSON.parse(error.message);
          this.errorMessage = errorResponse.error.message;
          console.log(this.errorResponse);
        }
      );
    }
  }
}
</script>

<style scoped>
@import "@/assets/css/LogInView.css";

</style>