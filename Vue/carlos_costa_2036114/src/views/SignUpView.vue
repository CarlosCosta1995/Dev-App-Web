<template>
<!-- partial:index.partial.html -->
  <div class="login-page">
    <div class="form">
        <form class="register-form acrylic">
          <span>Create a new account</span>
          <input type="email" placeholder="Email" v-model="Email"/>
          <input type="password" placeholder="Password" v-model="Password" required minlength="6" maxlength="20"/>
          <input type="password" placeholder="Password Confirm" v-model="PasswordConfirm" required minlength="6" maxlength="20"/>
          <span v-if="v$.PasswordConfirm.$error">{{ v$.PasswordConfirm.$errors[0].$message }}</span>
          <button id="SignUp" @click="signupRequest()">Go</button>
          <p class="message">
            <router-link to="/logIn">
              <a>I have Account</a>
            </router-link>
          </p>
        </form>
      <!-- <form class="login-form acrylic" action="../../index.html">
        <span>Login to your account</span>
        <input id="email" type="email" placeholder="Email" required/>
        <input id="pw" type="password" placeholder="Password" required minlength="4" maxlength="20"/>
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
        this.$router.push('/');
      } else {
        alert('Form failed validation');
        this.$router.push('/signUp');
      }
    },
    signupRequest() {
      firebase
      .auth()
      .createUserWithEmailAndPassword(this.Email, this.Password)
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