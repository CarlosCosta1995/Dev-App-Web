<template>
  <div class="about">
    <!-- partial:index.partial.html -->

    <form class="register-form acrylic">
        <span>Sign Up</span><br>
        <input type="email" placeholder="Email" required />
        <input type="password" placeholder="Password" required minlength="4" maxlength="20" />
        <button id="SignUp" @click="alert()">Go</button>
        <p class="message"><a href="#">I have Account</a></p>
      </form>
      <hr>
      <form class="login-form acrylic" action="../../index.html">
        <span>Login to your account</span><br>
        <input id="email" type="email" placeholder="Email" required/>
        <input id="pw" type="password" placeholder="Password" required minlength="4" maxlength="20"/>
        <input type="submit" value="Submit" id="SignIn"/>
        <p class="message"><a href="#">Create Account</a></p>
      </form>

    <!--<div class="form">
      <form class="register-form acrylic">
        <span>Sign Up</span>
        <input type="email" placeholder="Email" required />
        <input type="password" placeholder="Password" required minlength="18"/>
        <button id="SignUp" onclick="signupRequest()">Go</button>
        <p class="message"><a href="#">I have Account</a></p>
      </form>

      <form class="login-form acrylic" action="../../index.html">
        <span>Login to your account</span>
        <input id="email" type="email" placeholder="Email" required/>
        <input id="pw" type="password" placeholder="Password" required minlength="4" maxlength="20"/>
        <input type="submit" value="Submit" id="SignIn" />
        <p class="message"><a href="#">Create Account</a></p>
      </form>-->
    <!-- partial:index.partial.html 
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
    <div class="land"></div>
    </div>
  </div>-->
  </div>
</template>

<script>
import firebase from "firebase";
export default {
    name: "SignUp",
    data() {
      return {
        Email: "",
        Password: "",
      }
    },
    methods: {
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
      },
      f(){
        alert(this.Email)
      }
    }
</script>




<style scoped>
@import "@/assets/css/logIn.css";
@import url(https://fonts.googleapis.com/css?family=Roboto:300);

.login-page {
  width: 360px;
  padding: 1% 0 0;
  margin: auto;
}
.form {
  position: relative;
  z-index: 1;
  background: #FFFFFF;
  max-width: 360px;
  margin: 0 auto 100px;
  padding: 50px;
  text-align: center;
  box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
}
.form input {
  font-family: "Roboto", sans-serif;
  outline: 0;
  background: #A7D0E0;
  width: 100%;
  border: 0;
  margin: 0 0 15px;
  padding: 15px;
  box-sizing: border-box;
  font-size: 14px;
  -webkit-transition: all 0.5s ease;
  transition: all 0.5s ease;
  opacity: 0.6;
}
.form button {
  font-family: "Roboto", sans-serif;
  text-transform: uppercase;
  outline: 0;
  background: #A7D0E0;
  width: 100%;
  border: 0;
  padding: 15px;
  color: #000;
  font-size: 14px;
  -webkit-transition: all 0.5s ease;
  transition: all 0.5s ease;
  cursor: pointer;
  opacity: 0.6;
}
.form button:hover,.form button:active {
  background: #f0f0f0;
}
.form button:focus {
  box-shadow:0 0 20px #7BB1FF,0 0 20px #7BB1FF;
  background-color: #fff;
  border-radius: 10px;
  color: #fff;
  opacity: 1;
}
.form input:focus {
  box-shadow:0 0 20px #fff,0 0 20px #fff;
  border-radius: 10px;
  opacity: 1;
}
.form span{
  font-family: "Roboto", sans-serif;
  position: relative;
  display: inline-block;
  box-sizing: border-box;
  background: #A7D0E0;
  opacity: 0.8;
  padding: 10px;
  width: 100%;
  margin: 0 0 15px;
}


.form .message {
  margin: 15px 0 0;
  color: #fff;
  font-size: 15px;
}
.form .message a {
  color: #000;
  text-decoration: none;
}
.form .register-form {
  display: none;
}
.container {
  position: relative;
  z-index: 1;
  max-width: 300px;
  margin: 0 auto;
}
.container:before, .container:after {
  content: "";
  display: block;
  clear: both;
}
.container .info {
  margin: 50px auto;
  text-align: center;
}
.container .info h1 {
  margin: 0 0 15px;
  padding: 0;
  font-size: 36px;
  font-weight: 300;
  color: #1a1a1a;
}
.container .info span {
  color: #4d4d4d;
  font-size: 12px;
}
.container .info span a {
  color: #000000;
  text-decoration: none;
}
.container .info span .fa {
  color: #EF3B3A;
}
body, .acrylic::before {
  /*background: url("https://wallup.net/wp-content/uploads/2017/11/23/502910-Firewatch-night-forest.jpg");
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-position: center;
  background-size: cover;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;*/
  background-color: #ffdc8e;
  font-family: "Roboto", sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;      
}
/*Thanks Chris Shank*/
.acrylic::before {
  filter: blur(10px);
  content: "";
  position: absolute;
  left: -10px;
  top: -10px;
  width: calc(100% + 20px);
  height: calc(100% + 20px);
  z-index: -1;
}

.acrylic::after {
  content: "";
  position: absolute;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  z-index: -1;
  opacity: 0.3;
  border: 1px solid #fff;
  background: #fff;
  background-image: url(data:image/png;base64,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);
}

/* ================  BB-8 ===================*/
@-webkit-keyframes ball {
  0% {
    transform: rotate(360deg);
  }
  100% {
    transform: rotate(0deg);
  }
}
@keyframes ball {
  0% {
    transform: rotate(360deg);
  }
  100% {
    transform: rotate(0deg);
  }
}
@-webkit-keyframes head {
  0% {
    margin: -55px 45px 10px 15px;
  }
  50% {
    margin: -65px 45px 10px 20px;
  }
}
@keyframes head {
  0% {
    margin: -55px 45px 10px 15px;
  }
  50% {
    margin: -65px 45px 10px 20px;
  }
}
.tattoine {
  margin: auto;
  margin-left: 25%;
  display: block;
  flex-direction: column;
  height: 20.5vh;
}

.bb-8--shadow {
  width: 170px;
  height: 30px;
  background: rgba(0, 0, 0, 0.75);
  position: relative;
  border-radius: 50%;
  margin-top: -25px;
  margin-left: 30px;
}

.bb-8--shadow--2 {
  width: 150px;
  height: 30px;
  background: rgba(0, 0, 0, 0.45);
  position: relative;
  border-radius: 50%;
  margin-top: -55px;
  margin-left: 30px;
  transform: rotate(-20deg);
}

.head {
  width: 75px;
  height: 35.5px;
  border-radius: 50px 50px 0 0;
  position: absolute;
  margin: -55px 45px 10px 20px;
  transform: rotate(-30deg) translatex(-50px) translatey(5px);
  border: 5px solid #1C3C4F;
  background: #fff;
  z-index: 99999;
  -webkit-animation-name: head;
          animation-name: head;
  -webkit-animation-iteration-count: infinite;
          animation-iteration-count: infinite;
  -webkit-animation-timing-function: linear;
          animation-timing-function: linear;
  -webkit-animation-duration: 0.3s;
          animation-duration: 0.3s;
}
.head .eye {
  background: #2b8aa9;
  width: 15px;
  height: 15px;
  border-radius: 50%;
  border: 5px solid #1C3C4F;
  position: relative;
  margin: 5px auto;
}

.ball {
  background: #fff;
  width: 100px;
  height: 100px;
  border-radius: 50%;
  border: 5px solid #1C3C4F;
  z-index: 9999;
  position: relative;
  overflow: hidden;
  transition: 3s;
  -webkit-animation-name: ball;
          animation-name: ball;
  -webkit-animation-duration: 0.75s;
          animation-duration: 0.75s;
  -webkit-animation-iteration-count: infinite;
          animation-iteration-count: infinite;
  -webkit-animation-timing-function: linear;
          animation-timing-function: linear;
}
.ball .connect {
  position: absolute;
  height: 5px;
  width: 100px;
  background: #1C3C4F;
}
.ball .connect.one {
  margin-top: 25px;
}
.ball .connect.two {
  margin-top: 65px;
  transform: rotate(65deg);
  margin-left: -30px;
}
.ball .connect.three {
  margin-top: 65px;
  margin-left: 30px;
  transform: rotate(-45deg);
}
.ball__inner {
  width: 65px;
  height: 65px;
  border-radius: 50%;
  background: #FDC23E;
  position: absolute;
  display: flex;
  border: 5px solid #1C3C4F;
}
.ball__inner .inside {
  width: 30px;
  height: 30px;
  border-radius: 50%;
  border: 5px solid #1C3C4F;
  margin: auto;
  background: #A7D0E0;
}
.ball__inner.one {
  margin-top: 70px;
}
.ball__inner.two {
  margin-left: 50px;
}
.ball__inner.three {
  margin-left: -35px;
  margin-top: -10px;
}
</style>

