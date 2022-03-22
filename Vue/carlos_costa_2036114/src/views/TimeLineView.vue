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
/* @import "@/assets/css/TimeLineView.css"; */

body {
  background: #e6e6e6;
  font-family: "Roboto", sans-serif;
  font-weight: 400;
}

/*===== Vertical Timeline =====*/
#conference-timeline {
  position: relative;
  max-width: auto;
  width: 100%;
  /* margin: 0 auto; */
  padding-left: 2%;
  padding-right: 2%;
}
#conference-timeline .timeline-start,
#conference-timeline .timeline-end {
  display: table;
  font-family: "Roboto", sans-serif;
  font-size: 18px;
  font-weight: 900;
  text-transform: uppercase;
  background: #00b0bd;
  padding: 15px 23px;
  color: #fff;
  max-width: 5%;
  width: 100%;
  text-align: center;
  margin: 0 auto;
}
#conference-timeline .conference-center-line {
  position: absolute;
  width: 3px;
  height: 100%;
  top: 0;
  left: 50%;
  margin-left: -2px;
  background: #00b0bd;
  z-index: -1;
}
#conference-timeline .conference-timeline-content {
  padding-top: 67px;
  padding-bottom: 67px;
}
.timeline-article {
  width: 100%;
  height: 100%;
  position: relative;
  overflow: hidden;
  margin: 20px 0;
}
.timeline-article .content-left-container,
.timeline-article .content-right-container {
  max-width: 44%;
  width: 100%;
}
.timeline-article .timeline-author {
  display: block;
  font-weight: 400;
  font-size: 14px;
  line-height: 24px;
  color: #242424;
  text-align: right;
}
.timeline-article .content-left,
.timeline-article .content-right {
  position: relative;
  width: auto;
  border: 1px solid #ddd;
  background-color: #fff;
  box-shadow: 0 1px 3px rgba(0, 0, 0, 0.03);
  padding: 27px 25px;
}
.timeline-article p {
  margin: 0 0 0 60px;
  padding: 0;
  font-weight: 400;
  color: #242424;
  font-size: 14px;
  line-height: 24px;
  position: relative;
  left: 50px;
}
.timeline-article span.article-number {
  position: absolute;
  /* font-weight: 300;
  font-size: 44px; */
  top: 10px;
  left: 0px;
  color: #00b0bd;
  z-index: 9;
}
.timeline-article .content-left-container {
  float: left;
}
.timeline-article .content-right-container {
  float: right;
}
.timeline-article .content-left:before,
.timeline-article .content-right:before {
  position: absolute;
  top: 20px;
  font-size: 23px;
  font-family: "FontAwesome";
  color: #fff;
}
.timeline-article .content-left:before {
  content: "\f0da";
  right: -8px;
}
.timeline-article .content-right:before {
  content: "\f0d9";
  left: -8px;
}
.timeline-article .meta-date {
  position: absolute;
  top: 20%;
  left: 50%;
  width: 62px;
  height: 62px;
  margin-left: -31px;
  color: #fff;
  border-radius: 100%;
  background: #00b0bd;
  z-index: 99;
}
.timeline-article .meta-date .date,
.timeline-article .meta-date .month {
  display: block;
  text-align: center;
  font-weight: 900;
}
.timeline-article .meta-date .date {
  font-size: 30px;
  line-height: 40px;
}
.timeline-article .meta-date .month {
  font-size: 18px;
  line-height: 10px;
}
/*===== // Vertical Timeline =====*/

/*===== Resonsive Vertical Timeline =====*/
@media only screen and (max-width: 830px) {
  #conference-timeline .timeline-start,
  #conference-timeline .timeline-end {
    margin: 0;
  }
  #conference-timeline .conference-center-line {
    margin-left: 0;
    left: 50px;
  }
  .timeline-article .meta-date {
    margin-left: 0;
    left: 10px;
  }
  .timeline-article .content-left-container,
  .timeline-article .content-right-container {
    max-width: 100%;
    width: auto;
    float: none;
    margin-left: 110px;
    min-height: 53px;
  }
  .timeline-article .content-left-container {
    margin-bottom: 20px;
  }
  .timeline-article .content-left,
  .timeline-article .content-right {
    padding: 10px 25px;
    min-height: 65px;
  }
  .timeline-article .content-left:before {
    content: "\f0d9";
    right: auto;
    left: -8px;
  }
  .timeline-article .content-right:before {
    display: none;
  }
}
@media only screen and (max-width: 400px) {
  .timeline-article p {
    margin: 0;
  }
  .timeline-article p span.article-number {
    display: none;
  }
}
/*===== // Resonsive Vertical Timeline =====*/

/*========= SpaceShip icon ========*/
.spaceship {
  float: left;
  position: relative;
  margin-top: 30px;
  margin-left: 30%;
  top: 0px;
  left: 0px;
  width: 100px;
  height: 100px;
  background-color: rgba(248, 239, 190, 1);
  border: 5px solid rgba(129, 30, 14, 1);
  border-radius: 100px;
  box-shadow: 9px -9px 0px -3px rgba(205, 179, 68, 1) inset;
}
.spaceship:active {
  -webkit-animation: blast-off 5s;
  -moz-animation: blast-off 5s;
  -ms-animation: blast-off 5s;
  -o-animation: blast-off 5s;
}
.spaceship:before,
.spaceship:after {
  content: "";
  position: absolute;
  width: 20px;
  height: 26px;
  background-color: rgba(129, 30, 14, 1);
  -webkit-transform: rotate(45deg);
  -moz-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  -o-transform: rotate(45deg);
  transform: rotate(45deg);
  border-top-left-radius: 20px 50px;
  border-top-right-radius: 20px 50px;
  border-bottom-left-radius: 10px 2px;
  border-bottom-right-radius: 10px 2px;
  z-index: -1;
}
.spaceship:before {
  top: 0px;
  left: 0px;
  box-shadow: 2px 0px rgba(129, 30, 14, 1) inset,
    0px 4px rgba(129, 30, 14, 1) inset, 0px -3px rgba(129, 30, 14, 1) inset,
    4px 0px 0px rgba(250, 106, 62, 1) inset, 95px 0px rgba(129, 30, 14, 1);
  z-index: -2;
}
.spaceship:after {
  top: 39px;
  left: 29px;
  box-shadow: 2px 0px rgba(129, 30, 14, 1) inset,
    0px 4px rgba(129, 30, 14, 1) inset, 0px -2px rgba(129, 30, 14, 1) inset,
    6px 0px rgba(250, 106, 62, 1) inset;
  z-index: 1;
}

.flames,
.flames:before {
  position: absolute;
  width: 14px;
  height: 100px;
  background-color: rgba(205, 179, 68, 1);
  border-bottom-left-radius: 7px 90px;
  border-bottom-right-radius: 7px 90px;
  box-shadow: 0px -30px 0px 5px rgba(248, 239, 190, 1) inset;
}
.flames {
  top: 8px;
  left: -41px;
  -webkit-transform: rotate(45deg);
  -moz-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  -o-transform: rotate(45deg);
  transform: rotate(45deg);
  z-index: -2;
}
.flames:before {
  content: "";
  top: 0px;
  left: 94px;
}

.flames-2 {
  position: absolute;
  top: 41px;
  left: -22px;
  height: 130px;
  width: 14px;
  border-bottom-left-radius: 40px 500px;
  border-bottom-right-radius: 40px 500px;
  background-color: rgba(205, 179, 68, 1);
  border: 5px solid rgba(248, 239, 190, 1);
  border-top: none;
  border-bottom: 40px solid rgba(248, 239, 190, 1);
  -webkit-transform: rotate(45deg);
  -moz-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  -o-transform: rotate(45deg);
  transform: rotate(45deg);
}
.flames-2:before {
  content: "";
  position: absolute;
  top: -13px;
  left: -34px;
  width: 7px;
  height: 7px;
  background-color: rgba(129, 30, 14, 1);
  border-radius: 7px;
  box-shadow: 11px 10px 0px 0px rgba(129, 30, 14, 1),
    54px 10px rgba(129, 30, 14, 1), 64px 0px rgba(129, 30, 14, 1);
}

@-webkit-keyframes blast-off {
  0%,
  100% {
    top: 0px;
    left: 0px;
  }
  1% {
    top: 2px;
    left: 2px;
  }
  2% {
    top: -2px;
    left: 2px;
  }
  3% {
    top: 4px;
    left: -2px;
  }
  4% {
    top: 4px;
    left: 0px;
  }
  5% {
    top: -3px;
    left: -2px;
  }
  6% {
    top: 4px;
    left: 5px;
  }
  7% {
    top: -4px;
    left: 7px;
  }
  8% {
    top: 5px;
    left: -8px;
  }
  9% {
    top: -4px;
    left: 6px;
  }
  10% {
    top: 3px;
    left: -9px;
  }
  11% {
    top: 9px;
    left: -5px;
  }
  12% {
    top: 2px;
    left: 5px;
  }
  99% {
    top: -9999px;
    left: 9999px;
  }
}
@-moz-keyframes blast-off {
  0%,
  100% {
    top: 0px;
    left: 0px;
  }
  1% {
    top: 2px;
    left: 2px;
  }
  2% {
    top: -2px;
    left: 2px;
  }
  3% {
    top: 4px;
    left: -2px;
  }
  4% {
    top: 4px;
    left: 0px;
  }
  5% {
    top: -3px;
    left: -2px;
  }
  6% {
    top: 4px;
    left: 5px;
  }
  7% {
    top: -4px;
    left: 7px;
  }
  8% {
    top: 5px;
    left: -8px;
  }
  9% {
    top: -4px;
    left: 6px;
  }
  10% {
    top: 3px;
    left: -9px;
  }
  11% {
    top: 9px;
    left: -5px;
  }
  12% {
    top: 2px;
    left: 5px;
  }
  99% {
    top: -9999px;
    left: 9999px;
  }
}
@-ms-keyframes blast-off {
  0%,
  100% {
    top: 0px;
    left: 0px;
  }
  1% {
    top: 2px;
    left: 2px;
  }
  2% {
    top: -2px;
    left: 2px;
  }
  3% {
    top: 4px;
    left: -2px;
  }
  4% {
    top: 4px;
    left: 0px;
  }
  5% {
    top: -3px;
    left: -2px;
  }
  6% {
    top: 4px;
    left: 5px;
  }
  7% {
    top: -4px;
    left: 7px;
  }
  8% {
    top: 5px;
    left: -8px;
  }
  9% {
    top: -4px;
    left: 6px;
  }
  10% {
    top: 3px;
    left: -9px;
  }
  11% {
    top: 9px;
    left: -5px;
  }
  12% {
    top: 2px;
    left: 5px;
  }
  99% {
    top: -9999px;
    left: 9999px;
  }
}
@-o-keyframes blast-off {
  0%,
  100% {
    top: 0px;
    left: 0px;
  }
  1% {
    top: 2px;
    left: 2px;
  }
  2% {
    top: -2px;
    left: 2px;
  }
  3% {
    top: 4px;
    left: -2px;
  }
  4% {
    top: 4px;
    left: 0px;
  }
  5% {
    top: -3px;
    left: -2px;
  }
  6% {
    top: 4px;
    left: 5px;
  }
  7% {
    top: -4px;
    left: 7px;
  }
  8% {
    top: 5px;
    left: -8px;
  }
  9% {
    top: -4px;
    left: 6px;
  }
  10% {
    top: 3px;
    left: -9px;
  }
  11% {
    top: 9px;
    left: -5px;
  }
  12% {
    top: 2px;
    left: 5px;
  }
  99% {
    top: -9999px;
    left: 9999px;
  }
}

/* ============== Planets ======= */
.space {
	position: relative;
	top: 100px;
	left: 80px;
	width: 100%;
	height: 100%;
	/* background: #333; */
	/* overflow: hidden; */
}
.space .pluto {
	position: relative;
	top: 50%;
	left: 50%;
	z-index: 2;
}
.space .pluto .tentacle {
	position: absolute;
	top: -60px;
	right: -80px;
	z-index: 1;
	height: 70px;
	width: 70px;
	box-sizing: border-box;
	border-radius: 100%;
	border-left: 15px solid #1aae1e;
	-webkit-transform: rotate(-30deg);
	-ms-transform: rotate(-30deg);
	transform: rotate(-30deg);
	-webkit-animation: tentacle 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
	animation: tentacle 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
}
.space .pluto .flag {
	position: absolute;
	height: 17px;
	width: 15px;
	top: -57px;
	left: -1px;
	-webkit-animation: flag-pole 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
	animation: flag-pole 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
}
.space .pluto .flag:before {
	content: "";
	position: absolute;
	height: 17px;
	width: 2px;
	background: rgb(38, 44, 223);
}
.space .pluto .flag:after {
	content: "";
	position: absolute;
	height: 10px;
	width: 14px;
	left: 2px;
	top: 0;
	background: #aaa;
	-webkit-animation: flag-unfurl 12s cubic-bezier(0.645, 0.045, 0.355, 1)
		infinite;
	animation: flag-unfurl 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
}
.space .pluto .flag .small-tentacle {
	position: absolute;
	left: -16px;
	top: 3px;
	height: 50px;
	width: 50px;
	border-left: 10px solid #1aae1e;
	border-radius: 100%;
	-webkit-transform: rotate(25deg);
	-ms-transform: rotate(25deg);
	transform: rotate(25deg);
	-webkit-animation: small-tentacle 12s cubic-bezier(0.645, 0.045, 0.355, 1)
		infinite;
	animation: small-tentacle 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
	z-index: 2;
}
.space .pluto:before {
	content: "";
	position: absolute;
	top: 80px;
	left: -30px;
	height: 10px;
	width: 60px;
	background: rgba(0, 0, 0, 0.2);
	background: #222;
	border-radius: 100%;
}
.space .pluto .planet {
	box-sizing: border-box;
	position: absolute;
	border-radius: 100%;
	height: 120px;
	width: 120px;
	overflow: hidden;
	margin-left: -60px;
	margin-top: -60px;
	z-index: 2;
}
.space .pluto .planet .surface {
	position: absolute;
	border-radius: 100%;
	height: 140%;
	width: 140%;
	top: -30%;
	right: -10%;
	box-sizing: border-box;
	border: 30px solid rgba(0, 0, 0, 0.15);
	background: #f6ba7c;
}
.space .pluto .planet .crater1,
.space .pluto .planet .crater2,
.space .pluto .planet .crater3 {
	position: absolute;
	border-radius: 100%;
	background: rgba(0, 0, 0, 0.15);
	box-shadow: inset 3px 3px 0 rgba(0, 0, 0, 0.2);
}
.space .pluto .planet .crater1 {
	height: 20px;
	width: 20px;
	top: 32%;
	left: 17%;
}
.space .pluto .planet .crater2 {
	height: 10px;
	width: 10px;
	top: 26%;
	left: 55%;
	box-shadow: inset 2px 2px 0 rgba(0, 0, 0, 0.2);
}
.space .pluto .planet .crater3 {
	height: 10px;
	width: 10px;
	top: 60%;
	left: 40%;
	box-shadow: inset 2px 2px 0 rgba(0, 0, 0, 0.2);
}
.space .ship {
	position: absolute;
	right: 50%;
	top: 20%;
	margin-top: -55px;
	margin-right: -55px;
	height: 22px;
	background: rgba(246, 250, 7, 0.1);
	-webkit-transform-origin: 0% 100% 0;
	-ms-transform-origin: 0% 100% 0;
	transform-origin: 0% 100% 0;
	z-index: 1;
	-webkit-animation: ship 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
	animation: ship 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
}
.space .ship .ship-rotate {
	position: absolute;
	height: 22px;
	-webkit-transform: rotate(-110deg);
	-ms-transform: rotate(-110deg);
	transform: rotate(-110deg);
	-webkit-animation: ship-rotate 12s cubic-bezier(0.645, 0.045, 0.355, 1)
		infinite;
	animation: ship-rotate 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
}
.space .ship .pod {
	position: absolute;
	top: 0;
	left: -8px;
	height: 16px;
	width: 16px;
	background: #eee;
	border-radius: 100% 0 100% 0;
	-webkit-transform: rotate(-45deg);
	-ms-transform: rotate(-45deg);
	transform: rotate(-45deg);
}
.space .ship .fuselage {
	position: absolute;
	top: 14px;
	left: -6px;
	height: 8px;
	width: 12px;
	background: red;
	border-radius: 100% 100% 0 0;
}
.space .ship .fuselage:after {
	content: "";
	position: absolute;
	left: 2px;
	top: 100%;
	width: 0;
	height: 0;
	border-left: 4px solid transparent;
	border-right: 4px solid transparent;
	border-top: 6px solid red;
}
.space .ship-shadow {
	position: absolute;
	right: 10%;
	top: 50%;
	margin-right: -28px;
	margin-top: 83px;
	height: 4px;
	width: 16px;
	background: #222;
	border-radius: 100%;
	-webkit-animation: ship-shadow 12s cubic-bezier(0.645, 0.045, 0.355, 1)
		infinite;
	animation: ship-shadow 12s cubic-bezier(0.645, 0.045, 0.355, 1) infinite;
}

@-webkit-keyframes small-tentacle {
	0% {
		-webkit-transform: rotate(-60deg);
		transform: rotate(-60deg);
	}
	86% {
		-webkit-transform: rotate(-60deg);
		transform: rotate(-60deg);
	}
	89% {
		-webkit-transform: rotate(10deg);
		transform: rotate(10deg);
	}
	100% {
		-webkit-transform: rotate(10deg);
		transform: rotate(10deg);
	}
}

@keyframes small-tentacle {
	0% {
		-webkit-transform: rotate(-60deg);
		transform: rotate(-60deg);
	}
	86% {
		-webkit-transform: rotate(-60deg);
		transform: rotate(-60deg);
	}
	89% {
		-webkit-transform: rotate(10deg);
		transform: rotate(10deg);
	}
	100% {
		-webkit-transform: rotate(10deg);
		transform: rotate(10deg);
	}
}
@-webkit-keyframes tentacle {
	0% {
		-webkit-transform: rotate(-30deg);
		transform: rotate(-30deg);
	}
	75% {
		-webkit-transform: rotate(-30deg);
		transform: rotate(-30deg);
	}
	80% {
		-webkit-transform: rotate(-165deg) translate(6px, 8px);
		transform: rotate(-165deg) translate(6px, 8px);
	}
	82.5% {
		-webkit-transform: rotate(-165deg) translate(28px, -17px);
		transform: rotate(-165deg) translate(28px, -17px);
	}
	100% {
		-webkit-transform: rotate(-165deg) translate(35px, -22px);
		transform: rotate(-165deg) translate(35px, -22px);
	}
}
@keyframes tentacle {
	0% {
		-webkit-transform: rotate(-30deg);
		transform: rotate(-30deg);
	}
	75% {
		-webkit-transform: rotate(-30deg);
		transform: rotate(-30deg);
	}
	80% {
		-webkit-transform: rotate(-165deg) translate(6px, 8px);
		transform: rotate(-165deg) translate(6px, 8px);
	}
	82.5% {
		-webkit-transform: rotate(-165deg) translate(28px, -17px);
		transform: rotate(-165deg) translate(28px, -17px);
	}
	100% {
		-webkit-transform: rotate(-165deg) translate(35px, -22px);
		transform: rotate(-165deg) translate(35px, -22px);
	}
}
@-webkit-keyframes ship {
	0% {
		right: -10%;
		top: -10%;
		margin-top: -55px;
		margin-right: -55px;
	}
	40% {
		right: 50%;
		top: 50%;
	}
	79.5% {
		margin-top: -55px;
		margin-right: -55px;
	}
	84% {
		margin-top: -20px;
		margin-right: 0px;
	}
	100% {
		right: 50%;
		top: 50%;
		margin-top: 0px;
		margin-right: 0px;
	}
}
@keyframes ship {
	0% {
		right: -10%;
		top: -10%;
		margin-top: -55px;
		margin-right: -55px;
	}
	40% {
		right: 50%;
		top: 50%;
	}
	79.5% {
		margin-top: -55px;
		margin-right: -55px;
	}
	84% {
		margin-top: -20px;
		margin-right: 0px;
	}
	100% {
		right: 50%;
		top: 50%;
		margin-top: 0px;
		margin-right: 0px;
	}
}
@-webkit-keyframes ship-rotate {
	0% {
		-webkit-transform: rotate(-110deg);
		transform: rotate(-110deg);
	}
	20% {
		-webkit-transform: rotate(-110deg);
		transform: rotate(-110deg);
	}
	34% {
		-webkit-transform: rotate(47deg);
		transform: rotate(47deg);
	}
	79% {
		-webkit-transform: rotate(47deg);
		transform: rotate(47deg);
	}
	100% {
		-webkit-transform: rotate(47deg);
		transform: rotate(47deg);
	}
}
@keyframes ship-rotate {
	0% {
		-webkit-transform: rotate(-110deg);
		transform: rotate(-110deg);
	}
	20% {
		-webkit-transform: rotate(-110deg);
		transform: rotate(-110deg);
	}
	34% {
		-webkit-transform: rotate(47deg);
		transform: rotate(47deg);
	}
	79% {
		-webkit-transform: rotate(47deg);
		transform: rotate(47deg);
	}
	100% {
		-webkit-transform: rotate(47deg);
		transform: rotate(47deg);
	}
}
@-webkit-keyframes ship-shadow {
	0% {
		right: -10%;
		-webkit-transform: scale(1.4, 1);
		transform: scale(1.4, 1);
		opacity: 0.3;
	}
	40% {
		right: 50%;
		-webkit-transform: scale(0.75, 1);
		transform: scale(0.75, 1);
		opacity: 1;
	}
	100% {
		right: 50%;
	}
}
@keyframes ship-shadow {
	0% {
		right: -10%;
		-webkit-transform: scale(1.4, 1);
		transform: scale(1.4, 1);
		opacity: 0.3;
	}
	40% {
		right: 50%;
		-webkit-transform: scale(0.75, 1);
		transform: scale(0.75, 1);
		opacity: 1;
	}
	100% {
		right: 50%;
	}
}
@-webkit-keyframes planet-bump {
	0% {
		margin-left: 0;
	}
	39% {
		margin-left: 0;
	}
	40% {
		margin-left: -1px;
	}
	40.5% {
		margin-left: 1px;
	}
	41% {
		margin-left: 0;
	}
	100% {
		margin-left: 0;
	}
}
@keyframes planet-bump {
	0% {
		margin-left: 0;
	}
	39% {
		margin-left: 0;
	}
	40% {
		margin-left: -1px;
	}
	40.5% {
		margin-left: 1px;
	}
	41% {
		margin-left: 0;
	}
	100% {
		margin-left: 0;
	}
}
@-webkit-keyframes flag-pole {
	0% {
		top: -57px;
	}
	48% {
		top: -57px;
	}
	54% {
		top: -77px;
	}
	90% {
		top: -77px;
	}
	92% {
		top: -57px;
	}
	100% {
		top: -57px;
	}
}
@keyframes flag-pole {
	0% {
		top: -57px;
	}
	48% {
		top: -57px;
	}
	54% {
		top: -77px;
	}
	90% {
		top: -77px;
	}
	92% {
		top: -57px;
	}
	100% {
		top: -57px;
	}
}
@-webkit-keyframes flag-unfurl {
	0% {
		width: 0;
	}
	55% {
		width: 0;
	}
	60% {
		width: 14px;
	}
	90% {
		width: 14px;
	}
	100% {
		width: 14px;
	}
}
@keyframes flag-unfurl {
	0% {
		width: 0;
	}
	55% {
		width: 0;
	}
	60% {
		width: 14px;
	}
	90% {
		width: 14px;
	}
	100% {
		width: 14px;
	}
}

</style>