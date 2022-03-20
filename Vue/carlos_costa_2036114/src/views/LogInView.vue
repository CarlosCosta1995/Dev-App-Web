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

// <script>
// import useValidate from "@vuelidate/core";
// import { required } from "@vuelidate/validators";
// import firebase from "firebase";

// export default {
//   name: "SignUp",
//   data() {
//     return {
//       v$: useValidate(),
//       Email: "",
//       Password: "",
//       PasswordConfirm: "",
//     };
//   },
//   validations() {
//     return {
//       Email: {required},
//       Password: {required},
//       PasswordConfirm: {required},
//     }
//   },
//   methods: {
//     submitForm() {
//       this.v$.$validate() // checks all inputs
//       if (!this.v$.$error) { // if ANY fail validation
//         alert('Form successfully submitted.');
//         this.signupRequest();
//         this.$router.push('/admin');
//       } else {
//         alert('Form failed validation');
//         this.$router.push('/logIn');
//       }
//     },
//     signInRequest() {
//       firebase
//       .auth()
//       .signInWithEmailAndPassword(this.Email, this.Password)
//       .then ( 
//         () => {
//           this.sucessMessage = "Register Successfully.";
//         },
//         error => {
//           let errorResponse = JSON.parse(error.message);
//           this.errorMessage = errorResponse.error.message;
//           console.log(this.errorResponse);
//         }
//       );
//     }
//   }
// }
// </script>

<script setup>
import firebase from "firebase";
import "firebase/firestore";
import "firebase/auth";

export default {
  name: 'SignIn',
  data: function() {
    return {
      // v$: useValidate(),
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
    validateLoginInputs() {
      if (
        !/^\w+([-]?\w+)*@\w+([-]?\w+)*(\w{2,3})+$/.test(this.Email_login.value)
      ) {
        errorMessage.value = "Invalid Email address.";
      } else if (this.Password.value.length < 6) {
        errorMessage.value = "Password must contain at least 6 characters.";
      } else {
        signInRequest();
      }
    },
    signInRequest() {
      firebase
      .auth()
      .signInWithEmailAndPassword(this.Email, this.Password)
      .then ( 
        user => {
          alert('LogIn Successfully');
          this.router.push("/admin"); // redirect AdminPage
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

// <script setup>
//   // import { ref } from "vue";
//   import firebase from "firebase";
//   // import { useRouter } from "vue-router"; // import router

//   const Email = "";
//   const Password = "";
//   const errorMessage = "";
//   // const router = useRouter(); // get a reference to our vue router

//   const login = () => {
//     firebase
//       .auth() // get the auth api
//       .signInWithEmailAndPassword(this.Email.value, this.Password.value) // need .value because ref()
//       .then((data) => {
//         this.router.push("/"); // redirect to the feed
//       })
//       .catch((error) => {
//         console.log(error);
//         errorMessage.value = error.message;
//       });
//   };
// export default{
//   /* Sign In if Email and Password are valid*/
//   methods:
//   function validateLoginInputs() {
//     if (
//       !/^\w+([-]?\w+)*@\w+([-]?\w+)*(\w{2,3})+$/.test(this.Email_login.value)
//     ) {
//       errorMessage.value = "Invalid Email address.";
//     } else if (this.Password.value.length < 6) {
//       errorMessage.value = "Password must contain at least 6 characters.";
//     } else {
//       login();
//     }
//   }
// }
// </script>

<style scoped>
@import "@/assets/css/LogInView.css";

</style>

// Email and Password
// root@admin.root 
// password

