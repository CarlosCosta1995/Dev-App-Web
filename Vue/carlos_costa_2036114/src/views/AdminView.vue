<template>
  <div class="admin menu menu-open">
    <!-- Admin Side-Menu-->
    <header>
      <!--<a href="#" class="menu-toggle"><i class="material-icons">menu</i></a>-->
      <nav class="menu-side">
        <br />
        <img
          src="https://www.freeiconspng.com/uploads/go-back--gallery-for--contact-person-icon-png-21.png"
          width="50"
          alt="user_Icon"
          style="margin: 5%"
        />
        <br />
        <hr />
        <ul>
          <router-link to="/" style="text-decoration: none"
            ><li>HomePage</li></router-link
          >
          <!-- <a href="#" style="text-decoration: none;"><li>LogIn & Sign Up</li></a> -->
          <a href="#newShip" style="text-decoration: none"
            ><li>SpaceShip</li></a
          >
          <a href="#newPlanet" style="text-decoration: none"><li>Planet</li></a>
          <a href="#newRace" style="text-decoration: none"><li>Race</li></a>
          <a href="#contactUs" style="text-decoration: none"
            ><li>Contact Us</li></a
          >
        </ul>
      </nav>
    </header>

    <!-- Main Section-->
    <main id="content">
      <!--Form Register a new Spaceship-->
      <div id="newShip">
        <h1>Register a new Spaceship</h1>
        <form class="row g-3">
          <div class="col-md-6">
            <label for="shipName" class="form-label">Ship Name</label>
            <input
              type="text"
              v-model="shipName"
              class="form-control"
              id="shipName"
              placeholder="NEWAH : NCC-3569-A"
            />
          </div>
          <div class="col-md-6">
            <label for="registerNumber" class="form-label"
              >Register Number</label
            >
            <input
              type="text"
              v-model="registerNumber"
              class="form-control"
              id="registerNumber"
              placeholder="NCC-3569-A"
            />
          </div>
          <div class="col-md-6">
            <label for="shipType" class="form-label">Type of shipe</label>
            <input
              type="text"
              v-model="shipType"
              class="form-control"
              id="shipType"
              placeholder="Crossfield-class starship"
            />
          </div>
          <div class="col-md-6">
            <label for="buildDate" class="form-label">Build date</label>
            <input
              type="text"
              v-model="buildDate"
              class="form-control"
              id="buildDate"
              placeholder="November 2256"
            />
          </div>
          <div class="col-12">
            <label for="origin" class="form-label">Origin</label>
            <input
              type="text"
              v-model="origin"
              class="form-control"
              id="origin"
              placeholder="San Francisco Fleet Yards, Earth"
            />
          </div>
          <div class="col-12">
            <label for="shipCaptain" class="form-label">Captain(s)</label>
            <input
              type="text"
              v-model="shipCaptain"
              class="form-control"
              id="shipCaptain"
              placeholder="Captain Saru"
            />
          </div>
          <div class="col-md-4">
            <label for="shipAssets" class="form-label">Assets </label>
            <select id="shipAssets" v-model="shipAssets" class="form-select">
              <option selected>Choose...</option>
              <option>Artificial Inteligent</option>
              <option>Spore Drive</option>
              <option>Time-travel machine</option>
            </select>
          </div>
          <div class="col-md-4">
            <label for="shipSiblings" class="form-label">Siblings</label>
            <select
              id="shipSiblings"
              v-model="shipSiblings"
              class="form-select"
            >
              <option selected>Choose...</option>
              <option>USS Discovery</option>
              <option>USS Shenzhou</option>
              <option>USS Glenn</option>
            </select>
          </div>
          <div class="col-12">
            <button type="submit" class="btn btn-primary" @click="guardar()">
              Submit New Spaceship
            </button>
          </div>
        </form>
      </div>

      <!--Form Register a new Planet-->
      <div id="newPlanet">
        <h1>Register a new Planet</h1>
        <form class="row g-3">
          <div class="col-md-6">
            <label for="planetName" class="form-label">Planet Name</label>
            <input
              type="text"
              class="form-control"
              id="planetName"
              placeholder="Ni'Var [Vulcan(alternate reality)]"
            />
          </div>
          <div class="col-12">
            <label for="planetDescription" class="form-label"
              >Planet Description</label
            >
            <textarea
              class="form-control"
              name="comment"
              form="planetDescription"
            >
Ni'Var, formerly Vulcan, was an inhabited M-class planet in the Vulcan system of the Alpha Quadrant. It had no moons, but appeared to have close planetary companions. </textarea
            >
          </div>
          <div class="col-12">
            <label for="planetLocation" class="form-label"
              >Quadrant Location</label
            >
            <input
              type="text"
              class="form-control"
              id="planetLocation"
              placeholder="Orbiting 40 Eridani A.,Vulcan system, Alpha Quadrant"
            />
          </div>
          <div class="col-12">
            <label for="Satellite" class="form-label">Satellite(s)</label>
            <input
              type="text"
              class="form-control"
              id="Satellite"
              placeholder="None, one Satellite, ..."
            />
          </div>
          <div class="col-12">
            <label for="planetAffiliation" class="form-label"
              >Political affiliation</label
            >
            <input
              type="text"
              class="form-control"
              id="planetAffiliation"
              placeholder="United Federation of Planets, The Jedi Order, Vulcan High Command,..."
            />
          </div>
          <div class="col-md-6">
            <label for="cityName" class="form-label">City Name</label>
            <input
              type="text"
              class="form-control"
              id="cityName"
              placeholder="Vulcan "
            />
          </div>
          <div class="col-md-4">
            <label for="planetClassification" class="form-label"
              >Planetary classification
            </label>
            <select id="planetClassification" class="form-select">
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
            <label for="planetType" class="form-label">Type of Planet</label>
            <select id="planetType" class="form-select">
              <option selected>Choose...</option>
              <option>Binary Planet</option>
              <option>Capital planet</option>
              <option>Gas giant</option>
              <option>Homeworld</option>
              <option>Rogue planet</option>
            </select>
          </div>
          <div class="col-md-4">
            <label for="planetStatus" class="form-label"
              >Status of Planet</label
            >
            <select id="planetStatus" class="form-select">
              <option selected>Choose...</option>
              <option>Inhabited planet</option>
              <option>Uninhabited planet</option>
              <option>Delphic Expanse planet</option>
              <option>Unnamed planet</option>
            </select>
          </div>
          <div class="col-12">
            <button type="submit" class="btn btn-primary">
              Submit New Planet
            </button>
          </div>
        </form>
      </div>

      <!--Form Register a new Race-->
      <div id="newRace">
        <h1>Register a new Race</h1>
        <form class="row g-3">
          <div class="col-md-6">
            <label for="raceName" class="form-label">Race Name</label>
            <input
              type="text"
              class="form-control"
              id="raceName"
              placeholder="Andorian"
            />
          </div>
          <div class="col-12">
            <label for="racePlanet" class="form-label">Planet</label>
            <input
              type="text"
              class="form-control"
              id="racePlanet"
              placeholder="Aenar"
            />
          </div>
          <div class="col-12">
            <label for="raceBiology" class="form-label">Biology</label>
            <textarea class="form-control" name="comment" form="raceBiology">
Andorians have blue blood, blue skin, white hair, and antennae on the crown of the skull. The antennae were depicted as protruding from the forehead, and capable of movement, used for gesturing and balancing. The design of Andorians has changed with every new production; including the placement of their antennae, additional makeup appliances, and the blue shade of their skin.</textarea
            >
          </div>
          <div class="col-12">
            <label for="raceCulture" class="form-label"
              >Culture and traditions</label
            >
            <textarea
              class="form-control"
              name="comment"
              form="raceCulture"
            ></textarea>
          </div>
          <div class="col-12">
            <label for="raceReligion" class="form-label">Religion(s)</label>
            <input
              type="text"
              class="form-control"
              id="raceReligion"
              placeholder="The Way of the Prophets"
            />
          </div>
          <div class="col-12">
            <label for="racePolitics" class="form-label">Politics</label>
            <input
              type="text"
              class="form-control"
              id="racePolitics"
              placeholder=""
            />
          </div>
          <div class="col-md-6">
            <label for="raceCity" class="form-label">City Name</label>
            <input
              type="text"
              class="form-control"
              id="raceCity"
              placeholder="Vulcan "
            />
          </div>
          <div class="col-md-4">
            <label for="receFiliation" class="form-label"
              >Federation membership</label
            >
            <select id="receFiliation" class="form-select">
              <option selected>Choose...</option>
              <option>United Federation of Planets</option>
              <option>Clan Fett</option>
              <option>Commerce Guild</option>
              <option>Confederacy of Independant Systems</option>
              <option>Corporate Alliance</option>
              <option>Dark Lords of the Sith</option>
              <option>Death Watch</option>
              <option>First Order</option>
              <option>Free Ryloth movement</option>
              <option>Galactic Empire</option>
              <option>Galactic Republic</option>
              <option>Gungan Grand Army</option>
              <option>Hutts</option>
              <option>Intergalactic Banking Clan</option>
              <option>Jedi Order</option>
              <option>Lothal Rebels</option>
              <option>Mandalorian Clans</option>
              <option>Nightbrothers</option>
              <option>Nightsisters</option>
              <option>Nite Owls</option>
              <option>Rebel Alliance</option>
              <option>Shadow Collective</option>
              <option>The Resistance</option>
              <option>Techno Union</option>
              <option>Trade Federation</option>
              <option>Tusken Raiders</option>
              <option>Twi'lek Freedom Fighters</option>
            </select>
          </div>
          <div class="col-12">
            <button type="submit" class="btn btn-primary">
              Submit New Race
            </button>
          </div>
        </form>
      </div>

      <!--Form Email us-->
      <div id="contactUs">
        <h1>Contact Us</h1>
        <form class="row g-3">
          <div class="col-md-6">
            <label for="name" class="form-label">Name</label>
            <input
              type="text"
              class="form-control"
              id="name"
              placeholder="Name"
            />
          </div>
          <div class="col-md-6">
            <label for="email" class="form-label">Email</label>
            <input
              type="email"
              class="form-control"
              id="Name"
              placeholder="email@gmail.com"
            />
          </div>
          <div class="col-md-12">
            <label for="subject" class="form-label">Subject</label>
            <input
              type="text"
              class="form-control"
              id="subject"
              placeholder="Subject"
            />
          </div>
          <div class="col-12">
            <label for="inputMessage" class="form-label">Message</label>
            <textarea
              class="form-control"
              name="comment"
              form="inputMessage"
            ></textarea>
          </div>
          <div class="col-12">
            <button type="submit" value="submit" class="btn btn-primary">
              Send it!
            </button>
          </div>
        </form>
      </div>
    </main>
  </div>
</template>

<script setup>
// Faze post de um dos forms
// fazer v-models nos campos do form
// button submit ( função guardar e fazer o post)
//https://www.bezkoder.com/vue-firebase-realtime-database/

import axios from "axios";
export default {
  data() {
    return {
      shipName: "",
      registerNumber: "",
      shipType: "",
      buildDate: "",
      origin: "",
      shipCaptain: "",
      shipAssets: [],
      shipSiblings: '',
    };
  },
  methods: {
    guardar() {
      axios
        .post("https://project-vue-cc-default-rtdb.firebaseio.com/.json", {
          shipName: this.shipName,
        //   registerNumber: this.registerNumber,
        //   shipType: this.shipType,
        //   buildDate: this.buildDate,
        //   origin: this.origin,
        //   shipCaptain: this.shipCaptain,
          shipAssets: this.shipAssets,})
        //   shipSiblings: this.shipSiblings,
        // })

        // .then(() => console.log("wtv"));
        .then((response) => this.shipId = response.data.id, console.log("wtv"));
    },
  },
};
</script>

<style scoped>
@import "@/assets/css/AdminView.css";
</style>