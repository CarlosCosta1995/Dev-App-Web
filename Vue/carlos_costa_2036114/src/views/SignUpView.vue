<template>
<!-- partial:index.partial.html -->
  <div class="login-page">
    <div class="form">
        <div class="register-form acrylic">
          <span>Create a new account</span>
          <input type="Email" placeholder="Email" name="Email" v-model="Email"/>
          <input type="Password" placeholder="Password" name="Password" v-model="Password" required minlength="6" maxlength="20"/>
          <!-- <input type="Password" placeholder="Password Confirm" v-model="PasswordConfirm" required minlength="6" maxlength="20"/> -->
          <!-- <span v-if="v$.PasswordConfirm.$error">{{ v$.PasswordConfirm.$errors[0].$message }}</span> -->
          <button id="SignUp" v-on:click="registerButtonPressed">Go</button>
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
        </div>
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
//         this.$router.push('/');
//       } else {
//         alert('Form failed validation');
//         this.$router.push('/signUp');
//       }
//     },
//     signupRequest() {
//       firebase
//       .auth()
//       .createUserWithEmailAndPassword(this.Email, this.Password)
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

// <script setup> //"Working" so far
// import firebase from "firebase";
// import "firebase/firestore";
// import "firebase/auth";

// export default {
//   name: "SignUp",
//   data() {
//     return {
//       // v$: useValidate(),
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
//       validateRegisterInputs() {
//         if (!/^\w+([-]?\w+)*@\w+([-]?\w+)*(\w{2,3})+$/.test(Email.value)) {
//           errorMessage.value = "Invalid Email address.";
//         } else if (Password.value.length < 6) {
//           errorMessage.value = "Password must contain at least 6 characters.";
//         } else if (Password.value != PasswordConfirm.value) {
//           errorMessage.value = "Passwords do not match.";
//         } else {
//           signupRequest();
//         }
//     },
//     signupRequest() {
//       firebase
//       .auth()
//       .createUserWithEmailAndPassword(this.Email, this.Password)
//       .then ( 
//         user => {
//           alert('Register Successfully');
//           this.router.push("/logIn"); // redirect AdminPage
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

// <script setup>
//   // import { ref } from "vue";
//   import firebase from "firebase";
//   // import { useRouter } from "vue-router"; // import router

//   const Email = "";
//   const Password = "";
//   const PasswordConfirm = "";
//   const errorMessage = "";
//   // const router = useRouter(); // get a reference to our vue router

//   const register = () => {
//       firebase
//         .auth() // get the auth api
//         .createUserWithEmailAndPassword(this.Email.value, this.Password.value) // need .value because ref()
//         .then((data) => {
//           this.router.push("/");
//         })
//         .catch((error) => {
//           console.log(error);
//           errorMessage.value = error.message;
//         });
//     };

//   function validateRegisterInputs() {
//     if (!/^\w+([-]?\w+)*@\w+([-]?\w+)*(\w{2,3})+$/.test(Email.value)) {
//       errorMessage.value = "Invalid Email address.";
//     } else if (Password.value.length < 6) {
//       errorMessage.value = "Password must contain at least 6 characters.";
//     } else if (Password.value != PasswordConfirm.value) {
//       errorMessage.value = "Passwords do not match.";
//     } else {
//       register();
//     }
//   }
// </script>

// <script setup>
// import firebase from "firebase";
// import "firebase/firestore";
// import "firebase/auth";

// export default {
//   name: "SignUp",
//   data() {
//     return {
//       // v$: useValidate(),
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
//     async validateRegisterInputs() {
//       try {
//         firebase
//           .auth()
//           .createUserWithEmailAndPassword(this.Email, this.Password)
//           .then((cred) => {
//             return firebase
//               .firestore()
//               .collection("profiles")
//               .doc(cred.user.uid)
//               .set({
//                 email: this.Email,
//                 // fullName: this.fullName,
//                 // address: this.address,
//                 // postcode: this.postcode,
//               })
//               .then(() => {
//                 console.log("Document successfully written.");
//               });
//           })
//           .then(() => {
//             alert("Registration successful.");
//           })
//           .catch((error) => {
//             console.log(error.message);
//           });
//         this.$router.push("/logIn");
//       } catch (error) {
//         console.log("Error", error.message);
//         alert(error.message);
//       }
//     },
//   },
// }
// </script>


// <script setup>

// import firebase from "firebase";
// import "firebase/firestore";
// import "firebase/auth";

// export default {
//   name: "SignUp",
//   data() {
//     return {
//       Email: '',
//       Password: '',
//       PasswordConfirm: '',
//     };
//   },
//   methods: {
//      validateRegisterInputs(){
//         firebase.auth().createUserWithEmailAndPassword(this.Email, this.Password)
//         .then((userCredential) => {
//           // Signed in
//           var user = userCredential.user;
//           alert("Count created");
//           this.$router.push("/logIn");
//         })
//         .catch((error) => {
//           var errorCode = error.code;
//           var errorMessage = error.message;
//           alert("Error creating account");
//           this.$router.push("/singUp");
//         })
//       }
//     }
//   } 
// </script>

<script setup>
   import firebase from "firebase";

   export default {
     data() {
       return {
         Email: "",
         Password: "",
       };
     },
     methods: {
       async registerButtonPressed() {
         try {
           var {
             user
           } = await firebase
             .auth()
             .createUserWithEmailAndPassword(this.Email, this.Password);
           // signout
           firebase
             .auth()
             .signOut()
             .then(user => {
               console.log("user " + user);
               this.$router.push({ path: 'logIn' });
             });
         } catch (error) {
           console.log(error.message);
         }
       }
     }
   };
   
</script>

<style scoped>
@import "@/assets/css/LogInView.css";

</style>