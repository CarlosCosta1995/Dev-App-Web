<template>
<!-- partial:index.partial.html -->
  <div class="login-page">
    <div class="form">
        <form class="register-form acrylic">
          <span>Create a new account</span>
          <input type="email" placeholder="Email" required />
          <input type="password" placeholder="Password" required minlength="18"/>
          <button id="SignUp">Go</button>
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

</script>

<style scoped>
@import "@/assets/css/LogInView.css";

</style>