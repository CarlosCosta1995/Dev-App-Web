<template>
    <!-- Main Section-->
    <div id="content">
        <!--Form Register a new Spaceship-->
        <div id="newShip">
            <h1>Register a new Spaceship</h1>
        </div>

        <!--Form Register a new Planet-->
        <div id="newPlanet">
            <h1>Register a new Planet</h1>
            <form class="row g-3">
                <div class="col-md-6">
                  <label for="inputEmail4" class="form-label">Planet Name</label>
                  <input type="text" class="form-control" id="inputEmail4" placeholder="Ni'Var [Vulcan(alternate reality)]">
                </div>
                <div class="col-12">
                  <label for="inputPassword4" class="form-label">Planet Description</label>
                  <textarea class="form-control" name="comment" form="inputPassword4">Ni'Var, formerly Vulcan, was an inhabited M-class planet in the Vulcan system of the Alpha Quadrant. It had no moons, but appeared to have close planetary companions. </textarea>
                </div>
                <div class="col-12">
                  <label for="inputAddress" class="form-label">Quadrant Location</label>
                  <input type="text" class="form-control" id="inputAddress" placeholder="Orbiting 40 Eridani A.,Vulcan system, Alpha Quadrant">
                </div>
                <div class="col-12">
                  <label for="inputAddress2" class="form-label">Satellite(s)</label>
                  <input type="text" class="form-control" id="inputAddress2" placeholder="None, one Satellite, ...">
                </div>
                <div class="col-12">
                    <label for="inputAddress2" class="form-label">Political affiliation</label>
                    <input type="text" class="form-control" id="inputAddress2" placeholder="United Federation of Planets, The Jedi Order, Vulcan High Command,...">
                  </div>
                <div class="col-md-6">
                  <label for="inputCity" class="form-label">City Name</label>
                  <input type="text" class="form-control" id="inputCity" placeholder="Vulcan ">
                </div>
                <div class="col-md-4">
                    <label for="inputState" class="form-label">Planetary classification </label>
                    <select id="inputState" class="form-select">
                      <option selected>Choose...</option>
                      <option>class D worlds</option>
                      <option>class H worlds</option>
                      <option>class J worlds</option>
                      <option>class K worlds</option>
                      <option>class L worlds</option>
                      <option>class M worlds</option>
                      <option>class N worlds</option>
                      <option>class R worlds</option>
                      <option>class T worlds</option>
                      <option>class Y worlds</option>
                      <option>Unnamed or Asteroid</option>
                    </select>
                  </div>
                <div class="col-md-4">
                  <label for="inputState" class="form-label">Type of Planet</label>
                  <select id="inputState" class="form-select">
                    <option selected>Choose...</option>
                    <option>Binary Planet</option>
                    <option>Capital planet</option>
                    <option>Gas giant</option>
                    <option>Homeworld</option>
                    <option>Rogue planet</option>
                  </select>
                </div>
                <div class="col-md-4">
                    <label for="inputState" class="form-label">Status of Planet</label>
                    <select id="inputState" class="form-select">
                      <option selected>Choose...</option>
                      <option>Inhabited planet</option>
                      <option>Uninhabited planet</option>
                      <option>Delphic Expanse planet</option>
                      <option>Unnamed planet</option>
                    </select>
                  </div>
                <div class="col-12">
                  <button type="submit" class="btn btn-primary">Sign in</button>
                </div>
              </form>
        </div>

        <!--Form Register a new Race-->
        <div id="newRace">
            <h1>Register a new Race</h1>
        </div>
        
        <!--Form Email us-->
        <div id="contactUs">
            <h1>Contact Us</h1>
        </div>

    </div>
</template>

<style lang="css" scoped>
@import "@/assets/css/admin.css";
</style>