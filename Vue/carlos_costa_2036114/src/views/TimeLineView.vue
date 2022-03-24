<template>
  <!-- Vertical Timeline -->
  <section id="conference-timeline">
    <!-- <div class="timeline-start">Start</div> -->
    <div class="conference-center-line"></div>
    <div class="conference-timeline-content">
      <!-- Article -->
      <div class="timeline-article"  v-for="(item, id) in spaceShips" :key="id">
        <div class="content-left-container">
          <div class="content-left">
            <span class="article-number">
              <div class="spaceship">
                <div class="flames"></div>
                <div class="flames-2"></div>
              </div>
            </span>
            <p>
              <ul style="list-style: none;">
                <li><b>Ship Name:</b> {{ item.shipName }}</li>
                <li><b>Register Number:</b> {{ item.registerNumber }}</li>
                <li><b>Build date:</b> {{ item.buildDate }}</li>
                <li><b>Type of ship:</b> {{ item.shipType }}</li>
                <li><b>Origin:</b> {{ item.origin }}</li>
                <li><b>Assets:</b> {{ item.shipAssets }}</li>
                <li><b>Siblings:</b> {{ item.shipSiblings }}</li>
              </ul>
            </p>
          </div>
          <span class="timeline-author"><i>By Captain <b>{{ item.shipCaptain }}</b></i></span>
        </div>
        <div class="content-right-container">
          <div class="content-right">
            <span class="article-number">
              <div class="space">
                <div class="ship">
                  <div class="ship-rotate">
                    <div class="pod"></div>
                    <div class="fuselage"></div>
                  </div>
                </div>
                <div class="ship-shadow"></div>
                <div class="pluto">
                  <div class="tentacle"></div>
                  <div class="flag">
                    <div class="small-tentacle"></div>
                  </div>
                  <div class="planet">
                    <div class="surface"></div>
                    <div class="crater1"></div>
                    <div class="crater2"></div>
                    <div class="crater3"></div>
                  </div>
                </div>
              </div>
            </span>
            <p>
              <ul style="list-style: none;">
                <li><b>Planet Name:</b> {{ item.planetName }}</li>
                <li><b>Quadrant Location:</b> {{ item.planetLocation }}</li>
                <li><b>Satellite(s):</b> {{ item.planetLocation }}</li>
                <li><b>Political affiliation:</b> {{ item.planetAffiliation }}</li>
                <li><b>City Name:</b> {{ item.cityName }}</li>
                <li><b>Planetary classification:</b> {{ item.planetClassification }}</li>
                <li><b>Type of Planet:</b> {{ item.planetType }}</li>
                <li><b>Status of Planet:</b> {{ item.planetStatus }}</li>
              </ul>
            </p>
          </div>
          <span class="timeline-author"><i>Discovered by <b>{{ item.shipCaptain }}</b></i></span>
        </div>
        <div class="meta-date">
          <!-- <span class="date">18</span>
          <span class="month">APR</span> -->
        </div>
      </div>
      <!-- // Article -->

      <!-- Article -->
      <!-- <div class="timeline-article">
        <div class="content-left-container">
          <div class="content-left">
            <span class="article-number">
              <div class="spaceship">
                <div class="flames"></div>
                <div class="flames-2"></div>
              </div>
            </span>
            <p>
              When I orbited the Earth in a spaceship, I saw for the first time
              how beautiful our planet is. Mankind, let us preserve and increase
              this beauty, and not destroy it!
            </p>
          </div>
          <span class="timeline-author">John Doe</span>
        </div>
        <div class="content-right-container">
          <div class="content-right">
            <span class="article-number">
              <div class="spaceship">
                <div class="flames"></div>
                <div class="flames-2"></div>
              </div>
            </span>
            <p>
              When I orbited the Earth in a spaceship, I saw for the first time
              how beautiful our planet is. Mankind, let us preserve and increase
              this beauty, and not destroy it!
            </p>
          </div>
          <span class="timeline-author">John Doe</span>
        </div>
        <div class="meta-date">
        </div>
      </div> -->
      <!-- // Article -->

      <!-- Article -->
      <!-- <div class="timeline-article">
        <div class="content-left-container">
          <div class="content-left">
            <span class="article-number">
              <div class="spaceship">
                <div class="flames"></div>
                <div class="flames-2"></div>
              </div>
            </span>
            <p>
              When I orbited the Earth in a spaceship, I saw for the first time
              how beautiful our planet is. Mankind, let us preserve and increase
              this beauty, and not destroy it!
            </p>
          </div>
          <span class="timeline-author">John Doe</span>
        </div>
        <div class="content-right-container">
          <div class="content-right">
            <span class="article-number">
              <div class="spaceship">
                <div class="flames"></div>
                <div class="flames-2"></div>
              </div>
            </span>
            <p>
              When I orbited the Earth in a spaceship, I saw for the first time
              how beautiful our planet is. Mankind, let us preserve and increase
              this beauty, and not destroy it!
            </p>
          </div>
          <span class="timeline-author">John Doe</span>
        </div>
        <div class="meta-date">

        </div>
      </div> -->
      <!-- // Article -->
    </div>
    <!-- <div class="timeline-end">End</div> -->
  </section>
  <!-- // Vertical Timeline -->
</template>

<script>
//fazer get
// igual mas em vez de post faz get

import axios from "axios";

export default {
  name: "get-request-async-await",
  data() {
    return {
      spaceShips: null,
    };
  },

  async created() {
    // GET request using axios with async/await

    const response = await axios.get(
      "https://project-vue-cc-default-rtdb.firebaseio.com/.json"
    );
    this.spaceShips = response.data;
  },
};
</script>

<style scoped>
@import "@/assets/css/TimeLineView.css";
</style>