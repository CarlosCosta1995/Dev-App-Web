<template>
  <div class="home">
    <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
    <!-- <HelloWorld msg="Welcome to Your Vue.js App"/> -->
    <!-- ======= Welcome Section ======= -->
    <section id="home" class="d-flex flex-column justify-content-center">
      <!-- <div class="container" data-aos="zoom-in" data-aos-delay="100">
        <h1>Welcome abroad Shapceship NEWAH, Commander!</h1>
        <p>We have all prepared for your new adventure.</p>
      </div> -->
      <div id="letter">Welcome abroad <br />Shapceship NEWAH, Commander!</div>
      <div id="description">We have all prepared for your new adventure.</div>

      <div id="animation">
        <div class="spaceship">
          <div class="antenna"></div>
          <div class="body"></div>
          <div class="window"></div>
          <div class="fins"></div>
          <div class="rocket"></div>
          <div class="fireWrapper">
            <div class="fire">
              <div></div>
              <div></div>
              <div></div>
              <div></div>
              <div></div>
              <div></div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- End Hero -->

    <!-- ======= Main Content Section ======= -->
    <main id="main">
      <!-- ======= Presenting Newah A.I and SpaceShipe Properties ======= -->
      <section class="ship" style="background-color: #34496a;">
        <div class="container" data-aos="fade-up">
          <div class="row">
            <div class="section-title col-lg-6 align-self-start" style="color: white;">
              <p><b>Welcome aboard, Commander! I'm Eve, the artificial Inteligent system from NEWAH Shapceship.</b> 
                I will be your assistent on your new journey through the Universe.
                This is your SpaceShip to command! Captain Saru will assist you in controlling passengers and crew.
                <b>Be carefull! The space can be DANGEROUS!</b></p>
            </div>

            <div class="col-lg-6 align-self-end">
              <img src="@/assets/img/Eve.png" class="img-fluid" alt="Newah A.I" width="350px" height="350px">
            </div>
          </div>
        </div>
      </section>

      <section id="ship" class="myship">
        <div class="container" data-aos="fade-up">
          <div class="row">
            <div class="col-lg-4">
              <img src="@/assets/img/Discovery.png" class="img-fluid" alt="" />
            </div>
            <div class="col-lg-8 pt-4 pt-lg-0 content">
              <h3>ShapeShip <b>NEWAH : NCC-3569-A</b></h3>
              <p class="fst-italic">
                <em
                  >"All things can be understood once they are discovered; the
                  point is to discover them."</em
                >
                - <i>Galileo Galilei</i>
              </p>
              <div class="row">
                <div class="col-lg-6">
                  <ul>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Register Number:</strong> <span>NCC-3569-A</span>
                    </li>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Contructed:</strong> <span>November 2256</span>
                    </li>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Origin:</strong>
                      <span> San Francisco Fleet Yards, Earth</span>
                    </li>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Siblings:</strong>
                      <span>USS Discovery, USS Shenzhou and USS Glenn</span>
                    </li>
                  </ul>
                </div>
                <div class="col-lg-6">
                  <ul>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Class:</strong>
                      <span>Crossfield-class starship</span>
                    </li>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Federation:</strong>
                      <span>Federation Starfleet</span>
                    </li>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Captain:</strong> <span>Saru</span>
                    </li>
                    <li>
                      <i class="bi bi-chevron-right"></i>
                      <strong>Assets:</strong>
                      <span
                        >Artificial Inteligent, Spore Drive and Time-travel
                        machine.</span
                      >
                    </li>
                  </ul>
                </div>
              </div>
              <p style="color: black">
                <em
                  >"This ship bears the name Discovery. Never has that been more
                  fitting, or more prescient. She has carried us into the
                  future, and it will be our privilege to make that future
                  bright. Let us begin. Together."</em
                >
                - <i>Captain Saru, 3189 ("People of Earth")</i>
              </p>
              <br />
              <button
                class="btn btn-warnning"
                style="color: black; background-color: #0563bb"
              >
                <a href="./Pages/MoreInfo/SpaceShip.html" style="color: black"
                  >See More!</a
                >
              </button>
            </div>
          </div>
        </div>
      </section>
      <!-- End About Section -->

      <!-- Eeve Working div -->
      <div class="Evee" data-aos="fade-up">
        <div id="webgl"></div>
        <div class="svg-box">
          <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 800 600">
            <defs />
            <defs>
              <clipPath id="clip-path">
                <rect
                  id="graph-line-mask"
                  width="105.2"
                  height="66.7"
                  x="439.5"
                  y="186.6"
                  fill="none"
                />
              </clipPath>
              <clipPath id="clip-path-2">
                <path
                  id="body-mask"
                  fill="none"
                  d="M490.4 368.3c0 63.7-38 140-84.7 140s-84.8-76.3-84.8-140 38-90.6 84.8-90.6 84.7 26.9 84.7 90.6z"
                />
              </clipPath>
            </defs>
            <g id="Ship">
              <g id="mid-display">
                <rect
                  width="320.3"
                  height="207"
                  x="248.8"
                  y="116.3"
                  fill="#282e39"
                  stroke="#0ff"
                  stroke-miterlimit="10"
                  stroke-width="5"
                  opacity=".8"
                  rx="18.4"
                />
                <g id="graph-btm">
                  <path
                    id="graph-left"
                    fill="#0ff"
                    d="M439.7 292.1s4.5-19.4 8.7-19c3.6.3 4.6 9.2 7.3 9 3.4-.2 4-14 7.3-14.3 3-.2 4.7 10 8.3 10 4 0 5.1-12.6 8.8-12.8 4.1-.2 7.2 27.1 7.2 27.1z"
                  />
                  <path
                    id="graph-morph1"
                    fill="none"
                    d="M439.7 292.1s2.2-10.8 6.5-10.4c3.5.3 8.3-18.9 11-19 3.4-.3 5.6 9 9 8.7 3-.3 3.5-3.2 7-3.2 4 0 5.9 10.6 9.5 10.4 4.2-.2 4.7 13.5 4.7 13.5z"
                  />
                  <path
                    id="graph-right"
                    fill="#34496a"
                    d="M502.6 292.1s4.5-19.4 8.8-19c3.5.3 4.6 9.2 7.3 9 3.4-.2 3.9-14 7.3-14.3 3-.2 4.7 10 8.3 10 4 0 5-12.6 8.7-12.8 4.2-.2 7.3 27.1 7.3 27.1z"
                  />
                  <path
                    id="graph-morph2"
                    fill="none"
                    d="M502.6 292.1s4.5-9.8 8.8-9.4c3.5.3 4.6-6.8 7.3-7 3.4-.2 3.9 6.6 7.3 6.4 3-.3 4.7-17.9 8.3-17.9 4 0 5 16.5 8.7 16.3 4.2-.2 7.3 11.6 7.3 11.6z"
                  />
                </g>
                <g id="planet">
                  <circle
                    id="planet-base"
                    cx="332.2"
                    cy="207.8"
                    r="37.3"
                    fill="#34496a"
                  />
                  <ellipse
                    id="planet-circle"
                    cx="331.5"
                    cy="207.8"
                    fill="none"
                    stroke="#0ff"
                    stroke-miterlimit="10"
                    stroke-width="5"
                    rx="61.8"
                    ry="12.7"
                  />
                  <path
                    id="planet-top"
                    fill="#34496a"
                    d="M294.9 207.8a37.3 37.3 0 0174.6 0z"
                  />
                </g>
                <g class="graph-circle-lb" id="graph-cir-left">
                  <circle cx="290.4" cy="287.5" r="20.8" fill="#34496a" />
                  <path
                    fill="#0ff"
                    d="M290.4 287.5l5.3-20.1a20.8 20.8 0 0115.5 20z"
                  />
                </g>
                <g class="graph-circle-lb" id="graph-cir-mid">
                  <circle cx="345.4" cy="287.5" r="20.8" fill="#34496a" />
                  <path
                    fill="#0ff"
                    d="M345.4 287.5l5.2-20.1a20.8 20.8 0 0115.5 20z"
                  />
                </g>
                <g id="graph-cir">
                  <circle
                    cx="396.4"
                    cy="292.1"
                    r="16.4"
                    fill="none"
                    stroke="#34496a"
                    stroke-miterlimit="10"
                    stroke-width="2"
                  />
                  <circle
                    cx="396.4"
                    cy="292.1"
                    r="20.8"
                    fill="none"
                    stroke="#34496a"
                    stroke-miterlimit="10"
                    stroke-width="2"
                  />
                  <circle
                    cx="396.4"
                    cy="292.1"
                    r="11.6"
                    fill="none"
                    stroke="#34496a"
                    stroke-miterlimit="10"
                    stroke-width="2"
                  />
                  <circle
                    id="graph-cir-1"
                    cx="408"
                    cy="292.1"
                    r="2.3"
                    fill="#0ff"
                  />
                  <circle
                    id="graph-cir-2"
                    cx="396.4"
                    cy="275.7"
                    r="2.3"
                    fill="#0ff"
                  />
                  <circle
                    id="graph-cir-3"
                    cx="417.2"
                    cy="292.1"
                    r="2.3"
                    fill="#0ff"
                  />
                  <circle
                    id="graph-cir-mid-2"
                    cx="396.4"
                    cy="292.1"
                    r="2.3"
                    fill="#0ff"
                    data-name="graph-cir-mid"
                  />
                </g>
                <g id="graph-big" clip-path="url(#clip-path)">
                  <path
                    id="graph-line"
                    fill="none"
                    stroke="#0ff"
                    stroke-miterlimit="10"
                    stroke-width="5"
                    d="M439.7 206.4c26.3 0 26.3 34.2 52.6 34.2s26.3-34.2 52.6-34.2 26.3 34.2 52.6 34.2 26.3-34.2 52.6-34.2"
                  />
                </g>
                <circle cx="275.7" cy="139.7" r="11.8" fill="#34496a" />
                <circle
                  id="left-top-circle"
                  cx="275.7"
                  cy="139.7"
                  r="11.8"
                  fill="#0ff"
                />
                <line
                  x1="300.8"
                  x2="387.1"
                  y1="134.3"
                  y2="134.9"
                  fill="none"
                  stroke="#34496a"
                  stroke-linecap="round"
                  stroke-miterlimit="10"
                  stroke-width="5"
                />
                <line
                  x1="300.8"
                  x2="338.5"
                  y1="143.7"
                  y2="143.9"
                  fill="none"
                  stroke="#34496a"
                  stroke-linecap="round"
                  stroke-miterlimit="10"
                  stroke-width="5"
                />
                <circle
                  cx="448.1"
                  cy="161.4"
                  r="13.3"
                  fill="none"
                  stroke="#34496a"
                  stroke-miterlimit="10"
                  stroke-width="5"
                />
                <path
                  class="circles-top"
                  id="circle-l"
                  fill="none"
                  stroke="#0ff"
                  stroke-miterlimit="10"
                  stroke-width="5"
                  d="M448 148.2a13.3 13.3 0 11-13.2 13.3 13.3 13.3 0 0113.3-13.3"
                />
                <circle
                  cx="491.2"
                  cy="161.4"
                  r="13.3"
                  fill="none"
                  stroke="#34496a"
                  stroke-miterlimit="10"
                  stroke-width="5"
                />
                <path
                  class="circles-top"
                  id="circle-m"
                  fill="none"
                  stroke="#0ff"
                  stroke-miterlimit="10"
                  stroke-width="5"
                  d="M491.2 148.2a13.3 13.3 0 11-13.3 13.3 13.3 13.3 0 0113.3-13.3"
                />
                <circle
                  cx="534.4"
                  cy="161.4"
                  r="13.3"
                  fill="none"
                  stroke="#34496a"
                  stroke-miterlimit="10"
                  stroke-width="5"
                />
                <path
                  class="circles-top"
                  id="circle-r"
                  fill="none"
                  stroke="#0ff"
                  stroke-miterlimit="10"
                  stroke-width="5"
                  d="M534.4 148.2a13.3 13.3 0 11-13.3 13.3 13.3 13.3 0 0113.3-13.3"
                />
              </g>
              <g id="btm-display">
                <g id="right-display">
                  <g id="right-display-display">
                    <path
                      fill="#282e39"
                      stroke="#0ff"
                      stroke-miterlimit="10"
                      stroke-width="5"
                      d="M654.7 461H508.6c-10.5 0-15.8-8.5-12-19l26.2-72a29.9 29.9 0 0125.8-18.9h146c10.5 0 15.8 8.5 12 19l-26.2 72a29.9 29.9 0 01-25.7 18.8z"
                      opacity=".8"
                    />
                    <g id="bars">
                      <polygon
                        id="bar-3-btm"
                        fill="#34496a"
                        points="656.9 441.2 642.4 441.2 667.6 371.7 682.2 371.7 656.9 441.2"
                      />
                      <polygon
                        id="bar-3-top"
                        fill="#0ff"
                        points="656.9 441.2 642.4 441.2 653 412 667.5 412 656.9 441.2"
                      />
                      <polygon
                        id="bar-2-btm"
                        fill="#34496a"
                        points="633.7 441.2 619.2 441.2 644.5 371.7 659 371.7 633.7 441.2"
                      />
                      <polygon
                        id="bar-2-top"
                        fill="#0ff"
                        points="633.7 441.2 619.2 441.2 636 395.1 650.5 395.1 633.7 441.2"
                      />
                      <polygon
                        id="bar-1-btm"
                        fill="#34496a"
                        points="610.6 441.2 596.1 441.2 621.4 371.7 635.9 371.7 610.6 441.2"
                      />
                      <polygon
                        id="bar-1-top"
                        fill="#0ff"
                        points="610.6 441.2 596.1 441.2 604 419.5 618.5 419.5 610.6 441.2"
                      />
                    </g>
                    <g id="btns" fill="#0ff">
                      <ellipse
                        cx="546.8"
                        cy="379.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 546.8 379.3)"
                      />
                      <ellipse
                        cx="562.7"
                        cy="379.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 562.7 379.3)"
                      />
                      <ellipse
                        cx="578.6"
                        cy="379.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 578.6 379.3)"
                      />
                      <ellipse
                        cx="594.5"
                        cy="379.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 594.5 379.3)"
                      />
                      <ellipse
                        cx="540.6"
                        cy="396.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 540.6 396.3)"
                      />
                      <ellipse
                        cx="556.5"
                        cy="396.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 556.5 396.3)"
                      />
                      <ellipse
                        cx="572.4"
                        cy="396.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 572.4 396.3)"
                      />
                      <ellipse
                        cx="588.3"
                        cy="396.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 588.4 396.3)"
                      />
                      <ellipse
                        cx="534.4"
                        cy="413.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 534.4 413.3)"
                      />
                      <ellipse
                        cx="550.3"
                        cy="413.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 550.3 413.3)"
                      />
                      <ellipse
                        cx="566.2"
                        cy="413.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 566.2 413.3)"
                      />
                      <ellipse
                        cx="582.1"
                        cy="413.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 582.2 413.3)"
                      />
                      <ellipse
                        cx="528.2"
                        cy="430.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 528.2 430.3)"
                      />
                      <ellipse
                        cx="544.1"
                        cy="430.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 544.1 430.3)"
                      />
                      <ellipse
                        cx="560"
                        cy="430.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.6 562.3 429.7)"
                      />
                      <ellipse
                        cx="575.9"
                        cy="430.3"
                        rx="6.5"
                        ry="4.6"
                        transform="rotate(-39.8 576 430.3)"
                      />
                    </g>
                  </g>
                  <ellipse
                    id="right-display-shadow"
                    cx="593.3"
                    cy="508.4"
                    fill="#1e3855"
                    rx="74"
                    ry="10.9"
                  />
                </g>
                <g id="left-display">
                  <g id="left-display-display">
                    <path
                      fill="#282e39"
                      stroke="#0ff"
                      stroke-miterlimit="10"
                      stroke-width="5"
                      d="M299 461H153c-10.4 0-22-8.5-25.8-19L101 370c-3.8-10.4 1.6-18.9 12-18.9h146c10.5 0 22 8.5 25.9 18.9l26.2 72c3.8 10.4-1.6 19-12 19z"
                      opacity=".8"
                    />
                    <polygon
                      fill="#0ff"
                      points="153.1 433.3 155.7 440.3 158.2 447.3 153.6 443.8 148.9 440.3 151 436.8 153.1 433.3"
                    />
                    <polygon
                      fill="#0ff"
                      points="143 433.3 146.4 433.3 151.9 448.4 148.5 448.4 143 433.3"
                    />
                    <polygon
                      fill="#0ff"
                      points="193.8 448.4 191.3 441.4 188.7 434.4 193.4 437.9 198 441.4 195.9 444.9 193.8 448.4"
                    />
                    <polygon
                      fill="#0ff"
                      points="203.9 448.4 200.6 448.4 195.1 433.3 198.4 433.3 203.9 448.4"
                    />
                    <polygon
                      fill="#0ff"
                      points="164.4 433.3 167.8 433.3 173.3 448.4 169.9 448.4 164.4 433.3"
                    />
                    <polygon
                      fill="#0ff"
                      points="174 433.3 177.4 433.3 182.9 448.4 179.5 448.4 174 433.3"
                    />
                    <ellipse
                      cx="199"
                      cy="377.7"
                      fill="#34496a"
                      rx="5.4"
                      ry="7.7"
                      transform="rotate(-50.2 199 377.7)"
                    />
                    <polygon
                      fill="#0ff"
                      points="198.2 380.9 197 377.7 195.9 374.6 199.2 376.1 202.6 377.7 200.4 379.3 198.2 380.9"
                    />
                    <line
                      x1="217.3"
                      x2="267.5"
                      y1="377.7"
                      y2="377.7"
                      fill="#282e39"
                      stroke="#0ff"
                      stroke-linecap="round"
                      stroke-miterlimit="10"
                      stroke-width="5"
                      opacity=".8"
                    />
                    <ellipse
                      cx="206.2"
                      cy="397.6"
                      fill="#34496a"
                      rx="5.4"
                      ry="7.7"
                      transform="rotate(-50.2 206.2 397.6)"
                    />
                    <polygon
                      fill="#0ff"
                      points="205.4 400.7 204.2 397.6 203.1 394.4 206.4 396 209.8 397.6 207.6 399.2 205.4 400.7"
                    />
                    <line
                      x1="224.5"
                      x2="274.8"
                      y1="397.6"
                      y2="397.6"
                      fill="#282e39"
                      stroke="#0ff"
                      stroke-linecap="round"
                      stroke-miterlimit="10"
                      stroke-width="5"
                      opacity=".8"
                    />
                    <ellipse
                      cx="213.5"
                      cy="417.5"
                      fill="#34496a"
                      rx="5.4"
                      ry="7.7"
                      transform="rotate(-50.2 213.4 417.4)"
                    />
                    <polygon
                      fill="#0ff"
                      points="212.6 420.6 211.5 417.5 210.3 414.3 213.7 415.9 217 417.5 214.8 419 212.6 420.6"
                    />
                    <line
                      x1="231.8"
                      x2="282"
                      y1="417.5"
                      y2="417.5"
                      fill="#282e39"
                      stroke="#0ff"
                      stroke-linecap="round"
                      stroke-miterlimit="10"
                      stroke-width="5"
                      opacity=".8"
                    />
                    <ellipse
                      cx="220.7"
                      cy="437.3"
                      fill="#34496a"
                      rx="5.4"
                      ry="7.7"
                      transform="rotate(-50.2 220.7 437.3)"
                    />
                    <polygon
                      fill="#0ff"
                      points="219.8 440.5 218.7 437.3 217.6 434.2 220.9 435.8 224.3 437.3 222.1 438.9 219.8 440.5"
                    />
                    <line
                      x1="239"
                      x2="289.2"
                      y1="437.3"
                      y2="437.3"
                      fill="#282e39"
                      stroke="#0ff"
                      stroke-linecap="round"
                      stroke-miterlimit="10"
                      stroke-width="5"
                      opacity=".8"
                    />
                    <path
                      fill="#34496a"
                      d="M190.5 424.4h-46a7.4 7.4 0 01-6.5-4.7l-15.8-43.5c-1-2.6.4-4.7 3-4.7h46a7.4 7.4 0 016.5 4.7l15.8 43.5c1 2.6-.4 4.7-3 4.7z"
                    />
                    <ellipse
                      cx="157.8"
                      cy="398"
                      fill="#282e39"
                      rx="17.5"
                      ry="25.1"
                      transform="rotate(-50.2 157.8 398)"
                    />
                    <ellipse
                      cx="157.8"
                      cy="398"
                      fill="#282e39"
                      rx="5.1"
                      ry="7.3"
                      transform="rotate(-50.2 157.8 398)"
                    />
                    <path
                      fill="#0ff"
                      d="M159.8 405a10 10 0 01-8.8-6.4 5.8 5.8 0 01.5-5.4 5.3 5.3 0 014.4-2.2 10 10 0 018.8 6.4 5.8 5.8 0 01-.5 5.4 5.3 5.3 0 01-4.4 2.1zm-3.9-10.6a2 2 0 00-1.6.7 2.5 2.5 0 000 2.3 6.6 6.6 0 005.4 4 2 2 0 001.7-.6 2.5 2.5 0 000-2.3 6.6 6.6 0 00-5.5-4zM173.6 405h14.5l-5.1-14h-14.4a1.8 1.8 0 00-1.7 2.6l3.2 8.7a4.1 4.1 0 003.5 2.6z"
                    />
                  </g>
                  <ellipse
                    id="left-display-shadow"
                    cx="224.5"
                    cy="511.5"
                    fill="#1e3855"
                    rx="74"
                    ry="10.9"
                  />
                </g>
              </g>
              <g id="robot">
                <path
                  id="body-base"
                  fill="#fff"
                  d="M490.4 368.3c0 63.7-38 140-84.7 140s-84.8-76.3-84.8-140 38-90.6 84.8-90.6 84.7 26.9 84.7 90.6z"
                />
                <g id="robot-body">
                  <ellipse
                    id="robot-shadow"
                    cx="405.6"
                    cy="543.9"
                    fill="#1e3855"
                    rx="44.5"
                    ry="7.1"
                  />
                  <g clip-path="url(#clip-path-2)">
                    <g id="faces">
                      <g id="face">
                        <ellipse
                          id="face-back"
                          cx="560"
                          cy="340.9"
                          fill="#34496a"
                          rx="61.5"
                          ry="32.2"
                        />
                        <g class="eyes" id="eyes" fill="#0ff">
                          <ellipse cx="539.8" cy="340.9" rx="7.3" ry="13.7" />
                          <ellipse cx="579.1" cy="340.9" rx="7.3" ry="13.7" />
                        </g>
                      </g>
                      <g id="face-2" data-name="face">
                        <ellipse
                          id="face-back-2"
                          cx="256.9"
                          cy="340.9"
                          fill="#34496a"
                          data-name="face-back"
                          rx="61.5"
                          ry="32.2"
                        />
                        <g
                          class="eyes"
                          id="eyes-2"
                          fill="#0ff"
                          data-name="eyes"
                        >
                          <ellipse cx="236.7" cy="340.9" rx="7.3" ry="13.7" />
                          <ellipse cx="275.9" cy="340.9" rx="7.3" ry="13.7" />
                        </g>
                      </g>
                      <g id="charge">
                        <circle cx="406.8" cy="340.9" r="16.2" fill="#34496a" />
                        <rect
                          width="4.1"
                          height="13.9"
                          x="398.7"
                          y="334"
                          fill="#fff"
                        />
                        <rect
                          width="4.1"
                          height="13.9"
                          x="410.8"
                          y="334"
                          fill="#fff"
                        />
                      </g>
                    </g>
                  </g>
                </g>
                <path
                  id="right-hand"
                  fill="#fff"
                  d="M549.7 400.7c0 15.6-31.2 28.2-56.2 28.2s-34.2-12.6-34.2-28.2 9.2-28 34.2-28 56.2 12.5 56.2 28z"
                />
                <path
                  id="left-hand"
                  fill="#fff"
                  d="M255.6 400.7c0-15.5 31.2-28 56.2-28s34.2 12.5 34.2 28-9.3 28.2-34.2 28.2-56.2-12.6-56.2-28.2z"
                />
              </g>
              <path
                id="note-1"
                fill="none"
                d="M180 317l-3.5-3.8a1 1 0 00-1.7.7v8.1a6 6 0 00-2-.3c-2.5 0-4.6 1.6-4.6 3.5s2 3.5 4.7 3.5 4.6-1.5 4.6-3.5a3 3 0 00-.7-1.9v-6.8l1.7 1.8a1 1 0 101.5-1.4z"
              />
              <path
                id="note-2"
                fill="none"
                d="M203.4 323.4v-9.5a1 1 0 00-1-1h-9.3a1 1 0 00-1 1v8.1a6 6 0 00-2-.3c-2.5 0-4.6 1.6-4.6 3.5s2 3.5 4.7 3.5 4.6-1.5 4.6-3.5a2.9 2.9 0 00-.7-1.9V315h7.3v7.1a5.8 5.8 0 00-1.9-.3c-2.6 0-4.7 1.6-4.7 3.5s2.1 3.5 4.7 3.5 4.7-1.5 4.7-3.5a2.9 2.9 0 00-.8-1.8z"
              />
            </g>
          </svg>
        </div>
        <canvas class="webgl2"></canvas>
      </div>
      <!-- Eeve Working End-div -->

      <!-- ======= Facts Section ======= -->
      <section class="facts">
        <div class="container" data-aos="fade-up">
          <div class="section-title">
            <h2>Facts</h2>
            <p>
              The space are enormous, but our federation could catalog several
              different species within this space-time.<br />During our
              travelings with other commanders, We catalog parallel universes,
              sub-universes and mirror universe.<br />These new ways inpired us
              too continue searching for new forms of lifes and maintaining the
              security and peace.
            </p>
          </div>

          <div class="row">
            <div class="col-lg-2.5 col-md-4 mt-5 mt-lg-0">
              <div class="count-box">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  class="bi bi-meta"
                  viewBox="0 0 16 16"
                >
                  <path
                    fill-rule="evenodd"
                    d="M8.217 5.243C9.145 3.988 10.171 3 11.483 3 13.96 3 16 6.153 16.001 9.907c0 2.29-.986 3.725-2.757 3.725-1.543 0-2.395-.866-3.924-3.424l-.667-1.123-.118-.197a54.944 54.944 0 0 0-.53-.877l-1.178 2.08c-1.673 2.925-2.615 3.541-3.923 3.541C1.086 13.632 0 12.217 0 9.973 0 6.388 1.995 3 4.598 3c.319 0 .625.039.924.122.31.086.611.22.913.407.577.359 1.154.915 1.782 1.714Zm1.516 2.224c-.252-.41-.494-.787-.727-1.133L9 6.326c.845-1.305 1.543-1.954 2.372-1.954 1.723 0 3.102 2.537 3.102 5.653 0 1.188-.39 1.877-1.195 1.877-.773 0-1.142-.51-2.61-2.87l-.937-1.565ZM4.846 4.756c.725.1 1.385.634 2.34 2.001A212.13 212.13 0 0 0 5.551 9.3c-1.357 2.126-1.826 2.603-2.581 2.603-.777 0-1.24-.682-1.24-1.9 0-2.602 1.298-5.264 2.846-5.264.091 0 .181.006.27.018Z"
                  />
                </svg>
                <span class="purecounter">3</span>
                <p>Number of Universe</p>
              </div>
            </div>

            <div class="col-lg-2.5 col-md-4 mt-5 mt-lg-0">
              <div class="count-box">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  class="bi bi-tropical-storm"
                  viewBox="0 0 16 16"
                >
                  <path d="M8 9.5a2 2 0 1 0 0-4 2 2 0 0 0 0 4z" />
                  <path
                    d="M9.5 2c-.9 0-1.75.216-2.501.6A5 5 0 0 1 13 7.5a6.5 6.5 0 1 1-13 0 .5.5 0 0 1 1 0 5.5 5.5 0 0 0 8.001 4.9A5 5 0 0 1 3 7.5a6.5 6.5 0 0 1 13 0 .5.5 0 0 1-1 0A5.5 5.5 0 0 0 9.5 2zM8 3.5a4 4 0 1 0 0 8 4 4 0 0 0 0-8z"
                  />
                </svg>
                <span class="purecounter">47</span>
                <p>Galaxies</p>
              </div>
            </div>

            <div class="col-lg-2.5 col-md-4 mt-5 mt-lg-0">
              <div class="count-box">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  class="bi bi-globe"
                  viewBox="0 0 16 16"
                >
                  <path
                    d="M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm7.5-6.923c-.67.204-1.335.82-1.887 1.855A7.97 7.97 0 0 0 5.145 4H7.5V1.077zM4.09 4a9.267 9.267 0 0 1 .64-1.539 6.7 6.7 0 0 1 .597-.933A7.025 7.025 0 0 0 2.255 4H4.09zm-.582 3.5c.03-.877.138-1.718.312-2.5H1.674a6.958 6.958 0 0 0-.656 2.5h2.49zM4.847 5a12.5 12.5 0 0 0-.338 2.5H7.5V5H4.847zM8.5 5v2.5h2.99a12.495 12.495 0 0 0-.337-2.5H8.5zM4.51 8.5a12.5 12.5 0 0 0 .337 2.5H7.5V8.5H4.51zm3.99 0V11h2.653c.187-.765.306-1.608.338-2.5H8.5zM5.145 12c.138.386.295.744.468 1.068.552 1.035 1.218 1.65 1.887 1.855V12H5.145zm.182 2.472a6.696 6.696 0 0 1-.597-.933A9.268 9.268 0 0 1 4.09 12H2.255a7.024 7.024 0 0 0 3.072 2.472zM3.82 11a13.652 13.652 0 0 1-.312-2.5h-2.49c.062.89.291 1.733.656 2.5H3.82zm6.853 3.472A7.024 7.024 0 0 0 13.745 12H11.91a9.27 9.27 0 0 1-.64 1.539 6.688 6.688 0 0 1-.597.933zM8.5 12v2.923c.67-.204 1.335-.82 1.887-1.855.173-.324.33-.682.468-1.068H8.5zm3.68-1h2.146c.365-.767.594-1.61.656-2.5h-2.49a13.65 13.65 0 0 1-.312 2.5zm2.802-3.5a6.959 6.959 0 0 0-.656-2.5H12.18c.174.782.282 1.623.312 2.5h2.49zM11.27 2.461c.247.464.462.98.64 1.539h1.835a7.024 7.024 0 0 0-3.072-2.472c.218.284.418.598.597.933zM10.855 4a7.966 7.966 0 0 0-.468-1.068C9.835 1.897 9.17 1.282 8.5 1.077V4h2.355z"
                  />
                </svg>
                <span class="purecounter">86</span>
                <p>Number of Planets</p>
              </div>
            </div>

            <div class="col-lg-2.5 col-md-4 mt-5 mt-lg-0">
              <div class="count-box">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  class="bi bi-person"
                  viewBox="0 0 16 16"
                >
                  <path
                    d="M8 8a3 3 0 1 0 0-6 3 3 0 0 0 0 6zm2-3a2 2 0 1 1-4 0 2 2 0 0 1 4 0zm4 8c0 1-1 1-1 1H3s-1 0-1-1 1-4 6-4 6 3 6 4zm-1-.004c-.001-.246-.154-.986-.832-1.664C11.516 10.68 10.289 10 8 10c-2.29 0-3.516.68-4.168 1.332-.678.678-.83 1.418-.832 1.664h10z"
                  />
                </svg>
                <span class="purecounter">183</span>
                <p>Type of Races</p>
              </div>
            </div>

            <div class="col-lg-2.5 col-md-4 mt-5 mt-lg-0">
              <div class="count-box">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  class="bi bi-people"
                  viewBox="0 0 16 16"
                >
                  <path
                    d="M15 14s1 0 1-1-1-4-5-4-5 3-5 4 1 1 1 1h8zm-7.978-1A.261.261 0 0 1 7 12.996c.001-.264.167-1.03.76-1.72C8.312 10.629 9.282 10 11 10c1.717 0 2.687.63 3.24 1.276.593.69.758 1.457.76 1.72l-.008.002a.274.274 0 0 1-.014.002H7.022zM11 7a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm3-2a3 3 0 1 1-6 0 3 3 0 0 1 6 0zM6.936 9.28a5.88 5.88 0 0 0-1.23-.247A7.35 7.35 0 0 0 5 9c-4 0-5 3-5 4 0 .667.333 1 1 1h4.216A2.238 2.238 0 0 1 5 13c0-1.01.377-2.042 1.09-2.904.243-.294.526-.569.846-.816zM4.92 10A5.493 5.493 0 0 0 4 13H1c0-.26.164-1.03.76-1.724.545-.636 1.492-1.256 3.16-1.275zM1.5 5.5a3 3 0 1 1 6 0 3 3 0 0 1-6 0zm3-2a2 2 0 1 0 0 4 2 2 0 0 0 0-4z"
                  />
                </svg>
                <span class="purecounter">25</span>
                <p>Number of Federations</p>
              </div>
            </div>

            <div class="col-lg-2.5 col-md-4 mt-5 mt-lg-0">
              <div class="count-box">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="16"
                  height="16"
                  fill="currentColor"
                  class="bi bi-peace"
                  viewBox="0 0 16 16"
                >
                  <path
                    d="M7.5 1.018a7 7 0 0 0-4.79 11.566L7.5 7.793V1.018zm1 0v6.775l4.79 4.79A7 7 0 0 0 8.5 1.018zm4.084 12.273L8.5 9.207v5.775a6.97 6.97 0 0 0 4.084-1.691zM7.5 14.982V9.207l-4.084 4.084A6.97 6.97 0 0 0 7.5 14.982zM0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8z"
                  />
                </svg>
                <span class="purecounter">302225</span>
                <p>Number of Cultures</p>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- End Facts Section -->

      <!-- ======= Time-Line ======= -->
      <section class="timeline">
        <div
          class="section-title row"
          style="background-color: #34496a; padding: 2%"
        >
          <h2 style="color: white">Historical Time-line</h2>
          <div class="section-title">
              <img src="https://i.pinimg.com/originals/2b/b6/8f/2bb68fffd4127c7101cfc74b576d240f.gif" class="imgTime" alt="Start Trek Narrative TimeLine" width="300px" height="300px">
              <img src="https://i.pinimg.com/originals/e5/48/60/e5486034b3053e5877a8eebc44076722.gif" style="--color:#44D62C" class="imgTime" alt="Start Trek Narrative TimeLine" width="300px" height="300px">
              <img src="https://i.pinimg.com/originals/04/41/ea/0441ea5619b979bde781aa040943c208.gif" style="--color:#ff073a" alt="Start Trek Narrative TimeLine" class="imgTime" width="300px" height="300px">

            <p
              class="col-10 align-self-lg-center"
              style="color: white; margin-left: 10%"
            >
              There are several Cross Universe timeLines, which we can find
              diferent spicies and races. This races are influencing their own
              universe and by the historical events that happen or happenned in
              there.
            </p>
            <br />
            <button
              class="btn btn-warnning"
              style="color: white; background-color: #0563bb"
            >
              <a href="./Pages/MoreInfo/timeLine.html" style="color: white"
                >Discover more!</a
              >
            </button>
          </div>
        </div>
      </section>
      <!-- End Vertical time -->

      <!-- ======= Races Section ======= -->
      <!-- https://www.denofgeek.com/movies/best-star-wars-alien-species/ -->
      <section id="races" class="portfolio section-bg">
        <div class="container" data-aos="fade-up">
          <div class="section-title">
            <h2>Races</h2>
            <p>
              For your information, there are many races already knowed in the
              Universe.
            </p>
          </div>

          <div class="row">
            <div
              class="col-lg-12 d-flex justify-content-center"
              data-aos="fade-up"
              data-aos-delay="100"
            >
              <ul id="portfolio-flters">
                <li data-filter="*" class="filter-active">All</li>
                <li data-filter=".filter-app">A</li>
                <li data-filter=".filter-card">B</li>
                <li data-filter=".filter-web">C</li>
              </ul>
            </div>
          </div>

          <div
            class="row portfolio-container"
            data-aos="fade-up"
            data-aos-delay="200"
          >
            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
              <div class="portfolio-wrap">
                <img
                  src="https://upload.wikimedia.org/wikipedia/en/6/69/ProvingGround1.jpg"
                  class="img-fluid"
                  alt=""
                />
                <div class="portfolio-info">
                  <h4>Andorian</h4>
                  <!--<p>Inhabit the world of Andor (Andoria).</p>-->
                  <div class="portfolio-links">
                    <a
                      href="https://upload.wikimedia.org/wikipedia/en/6/69/ProvingGround1.jpg"
                      data-gallery="portfolioGallery"
                      class="portfolio-lightbox"
                      title="Andorians"
                      ><i class="bx bx-plus"></i
                    ></a>
                    <a
                      href="portfolio-details.html"
                      class="portfolio-details-lightbox"
                      data-glightbox="type: external"
                      title="Portfolio Details"
                      ><i class="bx bx-link"></i
                    ></a>
                  </div>
                </div>
              </div>
            </div>

            <div class="col-lg-4 col-md-6 portfolio-item filter-web">
              <div class="portfolio-wrap">
                <img
                  src="https://upload.wikimedia.org/wikipedia/en/b/bc/Borg_Queen_2372.jpg"
                  class="img-fluid"
                  alt=""
                />
                <div class="portfolio-info">
                  <h4>Borg</h4>
                  <div class="portfolio-links">
                    <a
                      href="https://upload.wikimedia.org/wikipedia/en/b/bc/Borg_Queen_2372.jpg"
                      data-gallery="portfolioGallery"
                      class="portfolio-lightbox"
                      title="Borg"
                      ><i class="bx bx-plus"></i
                    ></a>
                    <a
                      href="portfolio-details.html"
                      class="portfolio-details-lightbox"
                      data-glightbox="type: external"
                      title="Portfolio Details"
                      ><i class="bx bx-link"></i
                    ></a>
                  </div>
                </div>
              </div>
            </div>

            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
              <div class="portfolio-wrap">
                <img
                  src="https://s.yimg.com/uu/api/res/1.2/ColQ3SB079cQfZLb9.FXEg--~B/aD0yMDQ4O3c9MTM2ODthcHBpZD15dGFjaHlvbg--/http://media.zenfs.com/en/homerun/feed_manager_auto_publish_494/46ebb1c8649bc43e9331a622415440f8"
                  class="img-fluid"
                  alt=""
                />
                <div class="portfolio-info">
                  <h4>Vulcan</h4>
                  <div class="portfolio-links">
                    <a
                      href="https://s.yimg.com/uu/api/res/1.2/ColQ3SB079cQfZLb9.FXEg--~B/aD0yMDQ4O3c9MTM2ODthcHBpZD15dGFjaHlvbg--/http://media.zenfs.com/en/homerun/feed_manager_auto_publish_494/46ebb1c8649bc43e9331a622415440f8"
                      data-gallery="portfolioGallery"
                      class="portfolio-lightbox"
                      title="Vulcan"
                      ><i class="bx bx-plus"></i
                    ></a>
                    <a
                      href="portfolio-details.html"
                      class="portfolio-details-lightbox"
                      data-glightbox="type: external"
                      title="Portfolio Details"
                      ><i class="bx bx-link"></i
                    ></a>
                  </div>
                </div>
              </div>
            </div>

            <div class="col-lg-4 col-md-6 portfolio-item filter-card">
              <div class="portfolio-wrap">
                <img
                  src="https://miro.medium.com/max/1024/1*YxvChHHVQZq2AFvUltgijw@2x.jpeg"
                  class="img-fluid"
                  alt=""
                />
                <div class="portfolio-info">
                  <h4>Gungan</h4>
                  <div class="portfolio-links">
                    <a
                      href="https://miro.medium.com/max/1024/1*YxvChHHVQZq2AFvUltgijw@2x.jpeg"
                      data-gallery="portfolioGallery"
                      class="portfolio-lightbox"
                      title="Gungan"
                      ><i class="bx bx-plus"></i
                    ></a>
                    <a
                      href="portfolio-details.html"
                      class="portfolio-details-lightbox"
                      data-glightbox="type: external"
                      title="Portfolio Details"
                      ><i class="bx bx-link"></i
                    ></a>
                  </div>
                </div>
              </div>
            </div>

            <div class="col-lg-4 col-md-6 portfolio-item filter-web">
              <div class="portfolio-wrap">
                <img
                  src="https://cdn.vox-cdn.com/thumbor/N7E4hPnlQT-gkairuvCVi4CNmOs=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/19658558/the_child_star_wars_gallery_5e3204be4f668.jpg"
                  class="img-fluid"
                  alt=""
                />
                <div class="portfolio-info">
                  <h4>Lannik</h4>
                  <div class="portfolio-links">
                    <a
                      href="https://cdn.vox-cdn.com/thumbor/N7E4hPnlQT-gkairuvCVi4CNmOs=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/19658558/the_child_star_wars_gallery_5e3204be4f668.jpg"
                      data-gallery="portfolioGallery"
                      class="portfolio-lightbox"
                      title="Grogu - Lannik Species"
                      ><i class="bx bx-plus"></i
                    ></a>
                    <a
                      href="portfolio-details.html"
                      class="portfolio-details-lightbox"
                      data-glightbox="type: external"
                      title="Portfolio Details"
                      ><i class="bx bx-link"></i
                    ></a>
                  </div>
                </div>
              </div>
            </div>

            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
              <div class="portfolio-wrap">
                <img
                  src="https://i.pinimg.com/originals/fe/b7/29/feb72950856772dfc932d1c458e5677e.jpg"
                  class="img-fluid"
                  alt=""
                />
                <div class="portfolio-info">
                  <h4>Kamians</h4>
                  <div class="portfolio-links">
                    <a
                      href="https://i.pinimg.com/originals/fe/b7/29/feb72950856772dfc932d1c458e5677e.jpg"
                      data-gallery="portfolioGallery"
                      class="portfolio-lightbox"
                      title="Kamians"
                      ><i class="bx bx-plus"></i
                    ></a>
                    <a
                      href="portfolio-details.html"
                      class="portfolio-details-lightbox"
                      data-glightbox="type: external"
                      title="Portfolio Details"
                      ><i class="bx bx-link"></i
                    ></a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- Races Section -->
    </main>
  </div>
</template>

<script scoped>
// @ is an alias to /src
// import HelloWorld from '@/components/HelloWorld.vue'

export default {
  props: {
    msg: String
  },
    data() {
      return {
        sliding: null
      }
    },
    methods: {
      onSlideStart() {
        this.sliding = true
      },
      onSlideEnd() {
        this.sliding = false
      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
@import "@/assets/css/HomeView.css";

/* ============ Home Section ==========*/
#letter {
  font-size: 35px;
  font-family: Helvetica;
  font-weight: Bold;
  color: rgba(18, 22, 26, 0.7);
  /* width: 120px;
    height: 120px; */
  text-align: center;
  vertical-align: middle;
  /* line-height: 30px; */
  position: relative;
  top: 15%;
  /* left: 50%; */
  /* margin-top: -60px;
    margin-left: -60px; */
  opacity: 1;
  z-index: 90;
}

#description {
  position: relative;
  /* bottom: 10px; */
  width: 100%;
  z-index: 100;
  font-family: Helvetica;
  font-weight: 200;
  color: rgba(18, 22, 26, 0.7);
  text-align: center;
  font-size: 15px;
  letter-spacing: 1px;
  top: 25%;
}

#animation {
  position: relative;
  animation: flight 2s ease-in-out 0s infinite alternate none;
  -webkit-animation: flight 3s ease-in-out 0s infinite alternate none;
  /* width: 100%;
    height: 100%; */
  top: 5%;
  left: 15%;
  z-index: 99;
}

.spaceship {
  position: absolute;
  -webkit-transform: scale(0.76) rotate(45deg);
  -moz-transform: scale(0.76) rotate(45deg);
  -ms-transform: scale(0.76) rotate(45deg);
  -o-transform: scale(0.76) rotate(45deg);
  transform: scale(0.76) rotate(45deg);
  top: -25%;
  left: 0;
}

.spaceship .body {
  width: 300px;
  height: 300px;
  margin-top: -150px;
  margin-left: -150px;
  border-radius: 300px;
  position: absolute;
  box-shadow: -33px -33px 0px rgba(228, 230, 234, 0.6) inset;
  background-color: rgba(235, 236, 240, 1);
  -webkit-transform: scale(0.46, 1);
  -moz-transform: scale(0.46, 1);
  -ms-transform: scale(0.46, 1);
  -o-transform: scale(0.46, 1);
  transform: scale(0.46, 1);
  overflow: hidden;
}

.spaceship .body:before {
  content: "";
  position: absolute;
  width: 100%;
  height: 285px;
  background-color: rgba(255, 153, 145, 1);
  border-radius: 300px;
  -webkit-transform: scale(0.9, 0.46);
  -moz-transform: scale(0.9, 0.46);
  -ms-transform: scale(0.9, 0.46);
  -o-transform: scale(0.9, 0.46);
  transform: scale(0.9, 0.46);
  margin-top: -180px;
}

.spaceship .window {
  width: 40px;
  height: 40px;
  margin-top: -40px;
  margin-left: -26px;
  border: 6px solid rgba(215, 216, 220, 1);
  background-color: rgba(245, 246, 255, 1);
  overflow: hidden;
  position: absolute;
  border-radius: 40px;
}

.spaceship .window:before,
.spaceship .window:after {
  width: 5px;
  height: 60px;
  position: absolute;
  content: "";
  margin-left: 16px;
  margin-top: -5px;
  -webkit-transform: rotate(45deg);
  -moz-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  -o-transform: rotate(45deg);
  transform: rotate(45deg);
  background-color: #fff;
  opacity: 0.5;
}

.spaceship .window:before {
  margin-top: 10px;
}

.spaceship .fins {
  position: absolute;
  margin-top: -60px;
  z-index: -1;
}

.spaceship .fins:before,
.spaceship .fins:after {
  content: "";
  position: absolute;
  border-color: rgba(255, 153, 145, 1);
  height: 30px;
  border-top: 140px solid transparent;
  border-bottom: 20px solid transparent;
}

.spaceship .fins:before {
  border-right: 100px solid rgba(255, 153, 145, 1);
  margin-left: -100px;
}

.spaceship .fins:after {
  border-left: 100px solid rgba(255, 153, 145, 1);
}

.spaceship .antenna {
  position: absolute;
  background-color: rgba(235, 236, 240, 1);
  margin-top: -200px;
  margin-left: -2px;
  top: 50%;
  left: 50%;
  width: 4px;
  height: 60px;
}

.spaceship .antenna:before {
  width: 16px;
  height: 16px;
  content: "";
  background-color: rgba(235, 236, 240, 1);
  box-shadow: -3px -3px 0px rgba(225, 226, 230, 1) inset;
  position: absolute;
  border-radius: 16px;
  margin-top: -8px;
  margin-left: -6px;
}

.spaceship .rocket {
  width: 60px;
  height: 10px;
  position: absolute;
  border-top: 30px solid rgba(130, 134, 138, 1);
  border-right: 10px solid transparent;
  border-left: 10px solid transparent;
  margin-top: 120px;
  margin-left: -40px;
}

.spaceship .rocket:before {
  background-color: rgba(130, 134, 138, 1);
  margin-top: -70px;
  margin-left: -10px;
  position: absolute;
  content: "";
  border-radius: 80px;
  -webkit-transform: scale(1, 0.25);
  -moz-transform: scale(1, 0.25);
  -ms-transform: scale(1, 0.25);
  -o-transform: scale(1, 0.25);
  transform: scale(1, 0.25);
  width: 80px;
  height: 80px;
}

.spaceship .rocket:after {
  background-color: rgba(120, 124, 128, 1);
  margin-top: -30px;
  position: absolute;
  content: "";
  border-radius: 80px;
  -webkit-transform: scale(1, 0.15);
  -moz-transform: scale(1, 0.15);
  -ms-transform: scale(1, 0.15);
  -o-transform: scale(1, 0.15);
  transform: scale(1, 0.15);
  width: 60px;
  height: 60px;
}

.spaceship .fireWrapper {
  position: absolute;
  overflow: hidden;
  border-radius: 60px;
  width: 60px;
  height: 500px;
  margin-top: -66px;
  margin-left: -30px;
  z-index: 100;
  -webkit-transform: scale(1, 0.15);
  -moz-transform: scale(1, 0.15);
  -ms-transform: scale(1, 0.15);
  -o-transform: scale(1, 0.15);
  transform: scale(1, 0.15);
}

.fire {
  position: absolute;
  margin-top: 140px;
  width: 60px;
  height: 60px;
  opacity: 0.9;
  -webkit-transform: scale(1, 6.67);
  -moz-transform: scale(1, 6.67);
  -ms-transform: scale(1, 6.67);
  -o-transform: scale(1, 6.67);
  transform: scale(1, 6.67);
}

.fire div {
  position: absolute;
  -webkit-transform-origin: top center;
  transform-origin: top center;
  border-top: 30px solid rgba(255, 0, 0, 1);
  border-left: 25px solid transparent;
  border-right: 25px solid transparent;
  opacity: 0;
}

.fire div:nth-of-type(1) {
  animation: fire 0.35s linear 0s infinite alternate none;
  -webkit-animation: fire 0.35s linear 0s infinite alternate none;
  opacity: 0.8;
  margin-left: 5px;
  border-top-color: rgba(255, 190, 100, 1);
  border-top-width: 50px;
  z-index: -1;
}

.fire div:nth-of-type(2) {
  animation: fire 0.38s linear -0.5s infinite alternate none;
  -webkit-animation: fire 0.38s linear -0.5s infinite alternate none;
  opacity: 0.8;
  margin-left: 16px;
  border-top-color: rgba(255, 140, 100, 1);
  border-top-width: 40px;
  z-index: 0;
}

.fire div:nth-of-type(3) {
  animation: fire 0.4s linear -1s infinite alternate none;
  -webkit-animation: fire 0.4s linear -1s infinite alternate none;
  opacity: 0.8;
  margin-left: -6px;
  border-top-color: rgba(255, 160, 100, 1);
  border-top-width: 30px;
  z-index: 1;
}

.fire div:nth-of-type(4) {
  animation: fire 0.55s linear -1.2s infinite alternate none;
  -webkit-animation: fire 0.55s linear -1.2s infinite alternate none;
  opacity: 0.8;
  margin-left: 9px;
  border-left-width: 20px;
  border-right-width: 20px;
  border-top-color: rgba(255, 200, 100, 1);
  border-top-width: 50px;
  z-index: -1;
}

.fire div:nth-of-type(5) {
  animation: fire 0.25s linear -1.2s infinite alternate none;
  -webkit-animation: fire 0.25s linear -1.2s infinite alternate none;
  opacity: 0.8;
  margin-left: 14px;
  border-left-width: 25px;
  border-right-width: 25px;
  border-top-color: rgba(255, 220, 100, 1);
  border-top-width: 35px;
  z-index: 2;
}

.fire div:nth-of-type(6) {
  animation: fire 0.25s linear -1.2s infinite alternate none;
  -webkit-animation: fire 0.25s linear -1.2s infinite alternate none;
  opacity: 0.8;
  margin-left: -6px;
  border-left-width: 25px;
  border-right-width: 25px;
  border-top-color: rgba(255, 230, 110, 1);
  border-top-width: 35px;
  z-index: 2;
}

@keyframes fire {
  100% {
    -webkit-transform: skew(30deg);
    -moz-transform: skew(30deg);
    -ms-transform: skew(30deg);
    -o-transform: skew(30deg);
  }
  74% {
    -webkit-transform: skew(-15deg);
    -moz-transform: skew(-15deg);
    -ms-transform: skew(-15deg);
    -o-transform: skew(-15deg);
    transform: skew(-15deg);
  }
  58% {
    -webkit-transform: skew(10deg);
    -moz-transform: skew(10deg);
    -ms-transform: skew(10deg);
    -o-transform: skew(10deg);
    transform: skew(10deg);
  }
  30% {
    -webkit-transform: skew(-35deg);
    -moz-transform: skew(-35deg);
    -ms-transform: skew(-35deg);
    -o-transform: skew(-35deg);
    transform: skew(-35deg);
  }
  0% {
    -webkit-transform: skew(25deg);
    -moz-transform: skew(25deg);
    -ms-transform: skew(25deg);
    -o-transform: skew(25deg);
    transform: skew(25deg);
  }
}

@-webkit-keyframes fire {
  100% {
    -webkit-transform: skew(30deg);
    -moz-transform: skew(30deg);
    -ms-transform: skew(30deg);
    -o-transform: skew(30deg);
  }
  74% {
    -webkit-transform: skew(-15deg);
    -moz-transform: skew(-15deg);
    -ms-transform: skew(-15deg);
    -o-transform: skew(-15deg);
    transform: skew(-15deg);
  }
  58% {
    -webkit-transform: skew(10deg);
    -moz-transform: skew(10deg);
    -ms-transform: skew(10deg);
    -o-transform: skew(10deg);
    transform: skew(10deg);
  }
  30% {
    -webkit-transform: skew(-35deg);
    -moz-transform: skew(-35deg);
    -ms-transform: skew(-35deg);
    -o-transform: skew(-35deg);
    transform: skew(-35deg);
  }
  0% {
    -webkit-transform: skew(25deg);
    -moz-transform: skew(25deg);
    -ms-transform: skew(25deg);
    -o-transform: skew(25deg);
    transform: skew(25deg);
  }
}

@keyframes flight {
  100% {
    -webkit-transform: translate(40px, 60px) rotate(-4deg);
    -moz-transform: translate(40px, 60px);
    -ms-transform: translate(40px, 60px);
    -o-transform: translate(40px, 60px);
    transform: translate(40px, 60px);
  }
  66% {
    -webkit-transform: translate(-30px, -50px) rotate(5deg);
    -moz-transform: translate(-30px, -50px) rotate(5deg);
    -ms-transform: translate(-30px, -50px) rotate(5deg);
    -o-transform: translate(-30px, -50px) rotate(5deg);
    transform: translate(-30px, -50px) rotate(5deg);
  }
  36% {
    -webkit-transform: translate(50px, 40px) rotate(-6deg);
    -moz-transform: translate(50px, 40px) rotate(-6deg);
    -ms-transform: translate(50px, 40px) rotate(-6deg);
    -o-transform: translate(50px, 40px) rotate(-6deg);
    transform: translate(50px, 40px) rotate(-6deg);
  }
  0% {
    -webkit-transform: translate(-40px, -30px) rotate(5deg);
    -moz-transform: translate(-40px, -30px) rotate(5deg);
    -ms-transform: translate(-40px, -30px) rotate(5deg);
    -o-transform: translate(-40px, -30px) rotate(5deg);
    transform: translate(-40px, -30px) rotate(5deg);
  }
}

@-webkit-keyframes flight {
  100% {
    -webkit-transform: translate(40px, 60px) rotate(-4deg);
    -moz-transform: translate(40px, 60px);
    -ms-transform: translate(40px, 60px);
    -o-transform: translate(40px, 60px);
    transform: translate(40px, 60px);
  }
  66% {
    -webkit-transform: translate(-30px, -50px) rotate(5deg);
    -moz-transform: translate(-30px, -50px) rotate(5deg);
    -ms-transform: translate(-30px, -50px) rotate(5deg);
    -o-transform: translate(-30px, -50px) rotate(5deg);
    transform: translate(-30px, -50px) rotate(5deg);
  }
  36% {
    -webkit-transform: translate(50px, 40px) rotate(-6deg);
    -moz-transform: translate(50px, 40px) rotate(-6deg);
    -ms-transform: translate(50px, 40px) rotate(-6deg);
    -o-transform: translate(50px, 40px) rotate(-6deg);
    transform: translate(50px, 40px) rotate(-6deg);
  }
  0% {
    -webkit-transform: translate(-40px, -30px) rotate(5deg);
    -moz-transform: translate(-40px, -30px) rotate(5deg);
    -ms-transform: translate(-40px, -30px) rotate(5deg);
    -o-transform: translate(-40px, -30px) rotate(5deg);
    transform: translate(-40px, -30px) rotate(5deg);
  }
}

/* ============ Newah A.I ==========*/
.Evee {
  width: 100%;
  height: 50%;
  margin: 0;
  background: #34496a;
  overflow: hidden;
  display: block;
  justify-content: center;
  align-items: center;
}

#webgl {
  /* width: 100%;
  height: auto; */
  /* position: relative; */
  z-index: -1;
}

#webgl2 {
  /* position: relative; */
  top: 0;
  left: 0;
  outline: none;
  z-index: 2;
}

#bg-box {
  /* width: 100%;
  height: auto; */
  /* position: relative; */
  z-index: -1;
}

.svg-box {
  /* width: 100%;
  height: auto; */
  /* position: relative; */
  z-index: 1;
}
.svg-box #robot {
  cursor: pointer;
}

/*===== IMG Time-Line ====*/
.imgTime {
  --color: #fa6900; /* the color of the border */
  --border: 10px; /* the thickness of the border */
  --offset: 30px; /* control the movement of the border */
  --gap: 5px; /* the gap on hover */

  border-radius: 50%;
  cursor: pointer;
  padding: calc(var(--border) + var(--gap));
  border: var(--offset) solid #0000;
  --_m: radial-gradient(
    50% 50%,
    #000 calc(100% - var(--offset)),
    #0000 calc(100% - var(--border))
  );
  -webkit-mask: var(--_m);
  mask: var(--_m);
  --_g: #0000 calc(99% - var(--border)),
    var(--color) calc(100% - var(--border)) 99%, #0000;
  --_s: var(--offset);
  --_r: 100% 100% at;
  background: radial-gradient(var(--_r) 0 0, var(--_g)) calc(100% + var(--_s))
      calc(100% + var(--_s)),
    radial-gradient(var(--_r) 100% 0, var(--_g)) calc(0% - var(--_s))
      calc(100% + var(--_s)),
    radial-gradient(var(--_r) 0 100%, var(--_g)) calc(100% + var(--_s))
      calc(0% - var(--_s)),
    radial-gradient(var(--_r) 100% 100%, var(--_g)) calc(0% - var(--_s))
      calc(0% - var(--_s));
  background-size: 50% 50%;
  background-repeat: no-repeat;
  transition: 0.4s;
}
img:hover {
  --_s: 0px;
}
</style>