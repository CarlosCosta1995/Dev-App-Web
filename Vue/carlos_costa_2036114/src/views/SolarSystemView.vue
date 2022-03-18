<template>
  <div class="solarSystem opening hide-UI view-2D zoom-large data-close controls-close">>
    <div id="data">
      <a class="sun" title="sun" href="#sunspeed">Sun</a>
      <a class="mercury" title="mercury" href="#mercuryspeed">Andorian</a>
      <a class="venus" title="venus" href="#venusspeed">Lannik</a>
      <a class="earth active" title="earth" href="#earthspeed">Earth</a>
      <a class="mars" title="mars" href="#marsspeed">Naboo</a>
      <a class="jupiter" title="jupiter" href="#jupiterspeed">Ahch-To</a>
      <a class="saturn" title="saturn" href="#saturnspeed">Vulcan</a>
      <a class="uranus" title="uranus" href="#uranusspeed">Kamino</a>
      <a class="neptune" title="neptune" href="#neptunespeed">Kronos</a> 
    </div>
    <div id="controls">
      <label class="set-view">
        <input type="checkbox">
      </label>
      <label class="set-zoom">
        <input type="checkbox">
      </label>
      <label>
        <input type="radio" class="set-speed" name="scale" checked>
        <span>Speed</span>
      </label>
      <label>
        <input type="radio" class="set-size" name="scale">
        <span>Size</span>
      </label>
      <label>
        <input type="radio" class="set-distance" name="scale">
        <span>Distance</span>
      </label>
    </div>
    <div id="universe" class="scale-stretched">
      <div id="galaxy">
        <div id="solar-system" class="earth">
          <div id="mercury" class="orbit">
            <div class="pos">
              <div class="planet" style="background: radial-gradient(circle, rgba(55,93,91,1) 36%, rgba(51,231,220,1) 39%, rgba(72,255,228,0.3617646887856705) 44%);">
                <dl class="infos">
                  <dt>Andorian</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="venus" class="orbit">
            <div class="pos">
              <div class="planet" style="background: radial-gradient(circle, rgba(194,219,36,1) 29%, rgba(216,245,82,1) 35%, rgba(248,249,198,1) 36%, rgba(255,255,255,0.3617646887856705) 39%);">
                <dl class="infos">
                  <dt>Lannik</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="earth" class="orbit">
            <div class="pos">
              <div class="orbit">
                <div class="pos">
                  <div class="moon"></div>
                </div>
              </div>
              <div class="planet" style="background: radial-gradient(circle, rgba(12,96,179,1) 46%, rgba(10,208,251,1) 64%, rgba(181,221,237,0.6894957812226453) 81%);">
                <dl class="infos">
                  <dt>Earth</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="mars" class="orbit">
            <div class="pos">
              <div class="planet" style="background: radial-gradient(circle, rgba(79,36,219,1) 20%, rgba(70,151,236,1) 34%, rgba(55,186,240,1) 39%, rgba(33,255,196,0.20770306413581052) 47%);">
                <dl class="infos">
                  <dt>Naboo</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="jupiter" class="orbit">
            <div class="pos">
              <div class="planet" style="background: radial-gradient(circle, rgba(36,49,219,1) 20%, rgba(70,132,236,1) 34%, rgba(55,233,240,1) 39%, rgba(170,203,240,0.042436957693233524) 42%);">
                <dl class="infos">
                  <dt>Ahch-To</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="saturn" class="orbit">
            <div class="pos">
              <div class="planet" style="background: radial-gradient(circle, rgba(133,47,18,1) 20%, rgba(236,176,70,1) 23%, rgba(228,190,50,0.06204480083048847) 25%);">
                <div class="ring"></div>
                <dl class="infos">
                  <dt>Vulcan</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="uranus" class="orbit">
            <div class="pos">
              <div class="planet" style="background: radial-gradient(circle, rgba(157,29,132,1) 20%, rgba(202,98,246,1) 23%, rgba(215,115,245,0.06204480083048847) 25%); box-shadow: none;">
                <dl class="infos">
                  <dt>Kamino</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="neptune" class="orbit">
            <div class="pos">
              <div class="planet" style="background: radial-gradient(circle, rgba(200,35,35,0.9556022237996761) 36%, rgba(221,110,55,1) 46%, rgba(201,84,34,0.7091036243599003) 57%); box-shadow: none;">
                <dl class="infos">
                  <dt>Qo'noS (Kronos)</dt>
                  <dd><span></span></dd>
                </dl>
              </div>
            </div>
          </div>
          <div id="sun">
            <dl class="infos">
              <dt>Sun</dt>
              <dd><span></span></dd>
            </dl>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
@import "../assets/css/SolarSystem.css";

</style>
