@import url(fonts/clear-sans.css);
html, body {
  margin: 0;
  padding: 0;
  background: #faf8ef;
  color: #776E65;
  font-family: "Clear Sans", "Helvetica Neue", Arial, sans-serif;
  font-size: 18px; }

body {
  margin: 80px 0; }

.heading:after {
  content: "";
  display: block;
  clear: both; }

h1.title {
  font-size: 80px;
  font-weight: bold;
  margin: 0;
  display: block;
  float: left; }

@-webkit-keyframes $animation-name {
  0% {
    top: 25px;
    opacity: 1; }
  100% {
    top: -50px;
    opacity: 0; } }
@-moz-keyframes $animation-name {
  0% {
    top: 25px;
    opacity: 1; }
  100% {
    top: -50px;
    opacity: 0; } }
@keyframes $animation-name {
  0% {
    top: 25px;
    opacity: 1; }
  100% {
    top: -50px;
    opacity: 0; } }
.scores-container {
  float: right;
  text-align: right; }

.score-container, .best-container {
  position: relative;
  display: inline-block;
  background: #bbada0;
  padding: 15px 25px;
  font-size: 25px;
  height: 25px;
  line-height: 47px;
  font-weight: bold;
  border-radius: 3px;
  color: white;
  margin-top: 8px;
  text-align: center; }
  .score-container:after, .best-container:after {
    position: absolute;
    width: 100%;
    top: 10px;
    left: 0;
    text-transform: uppercase;
    font-size: 13px;
    line-height: 13px;
    text-align: center;
    color: #eee4da; }
  .score-container .score-addition, .best-container .score-addition {
    position: absolute;
    right: 30px;
    color: red;
    font-size: 25px;
    line-height: 25px;
    font-weight: bold;
    color: rgba(119, 110, 101, 0.9);
    z-index: 100;
    -webkit-animation: move-up 600ms ease-in;
    -moz-animation: move-up 600ms ease-in;
    animation: move-up 600ms ease-in;
    -webkit-animation-fill-mode: both;
    -moz-animation-fill-mode: both;
    animation-fill-mode: both; }

.score-container:after {
  content: "Score"; }

.best-container:after {
  content: "Best"; }

p {
  margin-top: 0;
  margin-bottom: 10px;
  line-height: 1.65; }

a {
  color: #776E65;
  font-weight: bold;
  text-decoration: underline;
  cursor: pointer; }

strong.important {
  text-transform: uppercase; }

hr {
  border: none;
  border-bottom: 1px solid #d8d4d0;
  margin-top: 20px;
  margin-bottom: 30px; }

.container {
  width: 500px;
  margin: 0 auto; }

@-webkit-keyframes $animation-name {
  0% {
    opacity: 0; }
  100% {
    opacity: 1; } }
@-moz-keyframes $animation-name {
  0% {
    opacity: 0; }
  100% {
    opacity: 1; } }
@keyframes $animation-name {
  0% {
    opacity: 0; }
  100% {
    opacity: 1; } }
.game-container {
  margin-top: 40px;
  position: relative;
  padding: 15px;
  cursor: default;
  -webkit-touch-callout: none;
  -ms-touch-callout: none;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  -ms-touch-action: none;
  touch-action: none;
  background: #bbada0;
  border-radius: 6px;
  width: 500px;
  height: 500px;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }
  .game-container .game-message {
    display: none;
    position: absolute;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    background: rgba(238, 228, 218, 0.5);
    z-index: 100;
    text-align: center;
    -webkit-animation: fade-in 800ms ease 1200ms;
    -moz-animation: fade-in 800ms ease 1200ms;
    animation: fade-in 800ms ease 1200ms;
    -webkit-animation-fill-mode: both;
    -moz-animation-fill-mode: both;
    animation-fill-mode: both; }
    .game-container .game-message p {
      font-size: 60px;
      font-weight: bold;
      height: 60px;
      line-height: 60px;
      margin-top: 222px; }
    .game-container .game-message .lower {
      display: block;
      margin-top: 59px; }
    .game-container .game-message a {
      display: inline-block;
      background: #8f7a66;
      border-radius: 3px;
      padding: 0 20px;
      text-decoration: none;
      color: #f9f6f2;
      height: 40px;
      line-height: 42px;
      margin-left: 9px; }
      .game-container .game-message a.keep-playing-button {
        display: none; }
    .game-container .game-message.game-won {
      background: rgba(237, 194, 46, 0.5);
      color: #f9f6f2; }
      .game-container .game-message.game-won a.keep-playing-button {
        display: inline-block; }
    .game-container .game-message.game-won, .game-container .game-message.game-over {
      display: block; }

.grid-container {
  position: absolute;
  z-index: 1; }

.grid-row {
  margin-bottom: 15px; }
  .grid-row:last-child {
    margin-bottom: 0; }
  .grid-row:after {
    content: "";
    display: block;
    clear: both; }

.grid-cell {
  width: 106.25px;
  height: 106.25px;
  margin-right: 15px;
  float: left;
  border-radius: 3px;
  background: rgba(238, 228, 218, 0.35); }
  .grid-cell:last-child {
    margin-right: 0; }

.tile-container {
  position: absolute;
  z-index: 2; }

.tile, .tile .tile-inner {
  width: 107px;
  height: 107px;
  line-height: 107px; }
.tile.tile-position-1-1 {
  -webkit-transform: translate(0px, 0px);
  -moz-transform: translate(0px, 0px);
  -ms-transform: translate(0px, 0px);
  transform: translate(0px, 0px); }
.tile.tile-position-1-2 {
  -webkit-transform: translate(0px, 121px);
  -moz-transform: translate(0px, 121px);
  -ms-transform: translate(0px, 121px);
  transform: translate(0px, 121px); }
.tile.tile-position-1-3 {
  -webkit-transform: translate(0px, 242px);
  -moz-transform: translate(0px, 242px);
  -ms-transform: translate(0px, 242px);
  transform: translate(0px, 242px); }
.tile.tile-position-1-4 {
  -webkit-transform: translate(0px, 363px);
  -moz-transform: translate(0px, 363px);
  -ms-transform: translate(0px, 363px);
  transform: translate(0px, 363px); }
.tile.tile-position-2-1 {
  -webkit-transform: translate(121px, 0px);
  -moz-transform: translate(121px, 0px);
  -ms-transform: translate(121px, 0px);
  transform: translate(121px, 0px); }
.tile.tile-position-2-2 {
  -webkit-transform: translate(121px, 121px);
  -moz-transform: translate(121px, 121px);
  -ms-transform: translate(121px, 121px);
  transform: translate(121px, 121px); }
.tile.tile-position-2-3 {
  -webkit-transform: translate(121px, 242px);
  -moz-transform: translate(121px, 242px);
  -ms-transform: translate(121px, 242px);
  transform: translate(121px, 242px); }
.tile.tile-position-2-4 {
  -webkit-transform: translate(121px, 363px);
  -moz-transform: translate(121px, 363px);
  -ms-transform: translate(121px, 363px);
  transform: translate(121px, 363px); }
.tile.tile-position-3-1 {
  -webkit-transform: translate(242px, 0px);
  -moz-transform: translate(242px, 0px);
  -ms-transform: translate(242px, 0px);
  transform: translate(242px, 0px); }
.tile.tile-position-3-2 {
  -webkit-transform: translate(242px, 121px);
  -moz-transform: translate(242px, 121px);
  -ms-transform: translate(242px, 121px);
  transform: translate(242px, 121px); }
.tile.tile-position-3-3 {
  -webkit-transform: translate(242px, 242px);
  -moz-transform: translate(242px, 242px);
  -ms-transform: translate(242px, 242px);
  transform: translate(242px, 242px); }
.tile.tile-position-3-4 {
  -webkit-transform: translate(242px, 363px);
  -moz-transform: translate(242px, 363px);
  -ms-transform: translate(242px, 363px);
  transform: translate(242px, 363px); }
.tile.tile-position-4-1 {
  -webkit-transform: translate(363px, 0px);
  -moz-transform: translate(363px, 0px);
  -ms-transform: translate(363px, 0px);
  transform: translate(363px, 0px); }
.tile.tile-position-4-2 {
  -webkit-transform: translate(363px, 121px);
  -moz-transform: translate(363px, 121px);
  -ms-transform: translate(363px, 121px);
  transform: translate(363px, 121px); }
.tile.tile-position-4-3 {
  -webkit-transform: translate(363px, 242px);
  -moz-transform: translate(363px, 242px);
  -ms-transform: translate(363px, 242px);
  transform: translate(363px, 242px); }
.tile.tile-position-4-4 {
  -webkit-transform: translate(363px, 363px);
  -moz-transform: translate(363px, 363px);
  -ms-transform: translate(363px, 363px);
  transform: translate(363px, 363px); }

.tile {
  position: absolute;
  -webkit-transition: 100ms ease-in-out;
  -moz-transition: 100ms ease-in-out;
  transition: 100ms ease-in-out;
  -webkit-transition-property: -webkit-transform;
  -moz-transition-property: -moz-transform;
  transition-property: transform; }
  .tile .tile-inner {
    border-radius: 3px;
    background: #eee4da;
    text-align: center;
    font-weight: bold;
    z-index: 10;
    font-size: 55px; }
  .tile.tile-2 .tile-inner {
    background: #eee4da;
    box-shadow: 0 0 30px 10px rgba(243, 215, 116, 0), inset 0 0 0 1px rgba(255, 255, 255, 0); }
  .tile.tile-4 .tile-inner {
    background: #eee1c9;
    box-shadow: 0 0 30px 10px rgba(243, 215, 116, 0), inset 0 0 0 1px rgba(255, 255, 255, 0); }
  .tile.tile-8 .tile-inner {
    color: #f9f6f2;
    background: #f3b27a; }
  .tile.tile-16 .tile-inner {
    color: #f9f6f2;
    background: #f69664; }
  .tile.tile-32 .tile-inner {
    color: #f9f6f2;
    background: #f77c5f; }
  .tile.tile-64 .tile-inner {
    color: #f9f6f2;
    background: #f75f3b; }
  .tile.tile-128 .tile-inner {
    color: #f9f6f2;
    background: #edd073;
    box-shadow: 0 0 30px 10px rgba(243, 215, 116, 0.2380952381), inset 0 0 0 1px rgba(255, 255, 255, 0.1428571429);
    font-size: 45px; }
    @media screen and (max-width: 520px) {
      .tile.tile-128 .tile-inner {
        font-size: 25px; } }
  .tile.tile-256 .tile-inner {
    color: #f9f6f2;
    background: #edcc62;
    box-shadow: 0 0 30px 10px rgba(243, 215, 116, 0.3174603175), inset 0 0 0 1px rgba(255, 255, 255, 0.1904761905);
    font-size: 45px; }
    @media screen and (max-width: 520px) {
      .tile.tile-256 .tile-inner {
        font-size: 25px; } }
  .tile.tile-512 .tile-inner {
    color: #f9f6f2;
    background: #edc950;
    box-shadow: 0 0 30px 10px rgba(243, 215, 116, 0.3968253968), inset 0 0 0 1px rgba(255, 255, 255, 0.2380952381);
    font-size: 45px; }
    @media screen and (max-width: 520px) {
      .tile.tile-512 .tile-inner {
        font-size: 25px; } }
  .tile.tile-1024 .tile-inner {
    color: #f9f6f2;
    background: #edc53f;
    box-shadow: 0 0 30px 10px rgba(243, 215, 116, 0.4761904762), inset 0 0 0 1px rgba(255, 255, 255, 0.2857142857);
    font-size: 35px; }
    @media screen and (max-width: 520px) {
      .tile.tile-1024 .tile-inner {
        font-size: 15px; } }
  .tile.tile-2048 .tile-inner {
    color: #f9f6f2;
    background: #edc22e;
    box-shadow: 0 0 30px 10px rgba(243, 215, 116, 0.5555555556), inset 0 0 0 1px rgba(255, 255, 255, 0.3333333333);
    font-size: 35px; }
    @media screen and (max-width: 520px) {
      .tile.tile-2048 .tile-inner {
        font-size: 15px; } }
  .tile.tile-super .tile-inner {
    color: #f9f6f2;
    background: #3c3a33;
    font-size: 30px; }
    @media screen and (max-width: 520px) {
      .tile.tile-super .tile-inner {
        font-size: 10px; } }

@-webkit-keyframes $animation-name {
  0% {
    opacity: 0;
    -webkit-transform: scale(0);
    -moz-transform: scale(0);
    -ms-transform: scale(0);
    transform: scale(0); }
  100% {
    opacity: 1;
    -webkit-transform: scale(1);
    -moz-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1); } }
@-moz-keyframes $animation-name {
  0% {
    opacity: 0;
    -webkit-transform: scale(0);
    -moz-transform: scale(0);
    -ms-transform: scale(0);
    transform: scale(0); }
  100% {
    opacity: 1;
    -webkit-transform: scale(1);
    -moz-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1); } }
@keyframes $animation-name {
  0% {
    opacity: 0;
    -webkit-transform: scale(0);
    -moz-transform: scale(0);
    -ms-transform: scale(0);
    transform: scale(0); }
  100% {
    opacity: 1;
    -webkit-transform: scale(1);
    -moz-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1); } }
.tile-new .tile-inner {
  -webkit-animation: appear 200ms ease 100ms;
  -moz-animation: appear 200ms ease 100ms;
  animation: appear 200ms ease 100ms;
  -webkit-animation-fill-mode: backwards;
  -moz-animation-fill-mode: backwards;
  animation-fill-mode: backwards; }

@-webkit-keyframes $animation-name {
  0% {
    -webkit-transform: scale(0);
    -moz-transform: scale(0);
    -ms-transform: scale(0);
    transform: scale(0); }
  50% {
    -webkit-transform: scale(1.2);
    -moz-transform: scale(1.2);
    -ms-transform: scale(1.2);
    transform: scale(1.2); }
  100% {
    -webkit-transform: scale(1);
    -moz-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1); } }
@-moz-keyframes $animation-name {
  0% {
    -webkit-transform: scale(0);
    -moz-transform: scale(0);
    -ms-transform: scale(0);
    transform: scale(0); }
  50% {
    -webkit-transform: scale(1.2);
    -moz-transform: scale(1.2);
    -ms-transform: scale(1.2);
    transform: scale(1.2); }
  100% {
    -webkit-transform: scale(1);
    -moz-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1); } }
@keyframes $animation-name {
  0% {
    -webkit-transform: scale(0);
    -moz-transform: scale(0);
    -ms-transform: scale(0);
    transform: scale(0); }
  50% {
    -webkit-transform: scale(1.2);
    -moz-transform: scale(1.2);
    -ms-transform: scale(1.2);
    transform: scale(1.2); }
  100% {
    -webkit-transform: scale(1);
    -moz-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1); } }
.tile-merged .tile-inner {
  z-index: 20;
  -webkit-animation: pop 200ms ease 100ms;
  -moz-animation: pop 200ms ease 100ms;
  animation: pop 200ms ease 100ms;
  -webkit-animation-fill-mode: backwards;
  -moz-animation-fill-mode: backwards;
  animation-fill-mode: backwards; }

.above-game:after {
  content: "";
  display: block;
  clear: both; }

.game-intro {
  float: left;
  line-height: 42px;
  margin-bottom: 0; }

.restart-button {
  display: inline-block;
  background: #8f7a66;
  border-radius: 3px;
  padding: 0 20px;
  text-decoration: none;
  color: #f9f6f2;
  height: 40px;
  line-height: 42px;
  display: block;
  text-align: center;
  float: right; }

.game-explanation {
  margin-top: 50px; }

@media screen and (max-width: 520px) {
  html, body {
    font-size: 15px; }

  body {
    margin: 20px 0;
    padding: 0 20px; }

  h1.title {
    font-size: 27px;
    margin-top: 15px; }

  .container {
    width: 280px;
    margin: 0 auto; }

  .score-container, .best-container {
    margin-top: 0;
    padding: 15px 10px;
    min-width: 40px; }

  .heading {
    margin-bottom: 10px; }

  .game-intro {
    width: 55%;
    display: block;
    box-sizing: border-box;
    line-height: 1.65; }

  .restart-button {
    width: 42%;
    padding: 0;
    display: block;
    box-sizing: border-box;
    margin-top: 2px; }

  .game-container {
    margin-top: 40px;
    position: relative;
    padding: 15px;
    cursor: default;
    -webkit-touch-callout: none;
    -ms-touch-callout: none;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    -ms-touch-action: none;
    touch-action: none;
    background: #bbada0;
    border-radius: 6px;
    width: 500px;
    height: 500px;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box; }
    .game-container .game-message {
      display: none;
      position: absolute;
      top: 0;
      right: 0;
      bottom: 0;
      left: 0;
      background: rgba(238, 228, 218, 0.5);
      z-index: 100;
      text-align: center;
      -webkit-animation: fade-in 800ms ease 1200ms;
      -moz-animation: fade-in 800ms ease 1200ms;
      animation: fade-in 800ms ease 1200ms;
      -webkit-animation-fill-mode: both;
      -moz-animation-fill-mode: both;
      animation-fill-mode: both; }
      .game-container .game-message p {
        font-size: 60px;
        font-weight: bold;
        height: 60px;
        line-height: 60px;
        margin-top: 222px; }
      .game-container .game-message .lower {
        display: block;
        margin-top: 59px; }
      .game-container .game-message a {
        display: inline-block;
        background: #8f7a66;
        border-radius: 3px;
        padding: 0 20px;
        text-decoration: none;
        color: #f9f6f2;
        height: 40px;
        line-height: 42px;
        margin-left: 9px; }
        .game-container .game-message a.keep-playing-button {
          display: none; }
      .game-container .game-message.game-won {
        background: rgba(237, 194, 46, 0.5);
        color: #f9f6f2; }
        .game-container .game-message.game-won a.keep-playing-button {
          display: inline-block; }
      .game-container .game-message.game-won, .game-container .game-message.game-over {
        display: block; }

  .grid-container {
    position: absolute;
    z-index: 1; }

  .grid-row {
    margin-bottom: 15px; }
    .grid-row:last-child {
      margin-bottom: 0; }
    .grid-row:after {
      content: "";
      display: block;
      clear: both; }

  .grid-cell {
    width: 106.25px;
    height: 106.25px;
    margin-right: 15px;
    float: left;
    border-radius: 3px;
    background: rgba(238, 228, 218, 0.35); }
    .grid-cell:last-child {
      margin-right: 0; }

  .tile-container {
    position: absolute;
    z-index: 2; }

  .tile, .tile .tile-inner {
    width: 107px;
    height: 107px;
    line-height: 107px; }
  .tile.tile-position-1-1 {
    -webkit-transform: translate(0px, 0px);
    -moz-transform: translate(0px, 0px);
    -ms-transform: translate(0px, 0px);
    transform: translate(0px, 0px); }
  .tile.tile-position-1-2 {
    -webkit-transform: translate(0px, 121px);
    -moz-transform: translate(0px, 121px);
    -ms-transform: translate(0px, 121px);
    transform: translate(0px, 121px); }
  .tile.tile-position-1-3 {
    -webkit-transform: translate(0px, 242px);
    -moz-transform: translate(0px, 242px);
    -ms-transform: translate(0px, 242px);
    transform: translate(0px, 242px); }
  .tile.tile-position-1-4 {
    -webkit-transform: translate(0px, 363px);
    -moz-transform: translate(0px, 363px);
    -ms-transform: translate(0px, 363px);
    transform: translate(0px, 363px); }
  .tile.tile-position-2-1 {
    -webkit-transform: translate(121px, 0px);
    -moz-transform: translate(121px, 0px);
    -ms-transform: translate(121px, 0px);
    transform: translate(121px, 0px); }
  .tile.tile-position-2-2 {
    -webkit-transform: translate(121px, 121px);
    -moz-transform: translate(121px, 121px);
    -ms-transform: translate(121px, 121px);
    transform: translate(121px, 121px); }
  .tile.tile-position-2-3 {
    -webkit-transform: translate(121px, 242px);
    -moz-transform: translate(121px, 242px);
    -ms-transform: translate(121px, 242px);
    transform: translate(121px, 242px); }
  .tile.tile-position-2-4 {
    -webkit-transform: translate(121px, 363px);
    -moz-transform: translate(121px, 363px);
    -ms-transform: translate(121px, 363px);
    transform: translate(121px, 363px); }
  .tile.tile-position-3-1 {
    -webkit-transform: translate(242px, 0px);
    -moz-transform: translate(242px, 0px);
    -ms-transform: translate(242px, 0px);
    transform: translate(242px, 0px); }
  .tile.tile-position-3-2 {
    -webkit-transform: translate(242px, 121px);
    -moz-transform: translate(242px, 121px);
    -ms-transform: translate(242px, 121px);
    transform: translate(242px, 121px); }
  .tile.tile-position-3-3 {
    -webkit-transform: translate(242px, 242px);
    -moz-transform: translate(242px, 242px);
    -ms-transform: translate(242px, 242px);
    transform: translate(242px, 242px); }
  .tile.tile-position-3-4 {
    -webkit-transform: translate(242px, 363px);
    -moz-transform: translate(242px, 363px);
    -ms-transform: translate(242px, 363px);
    transform: translate(242px, 363px); }
  .tile.tile-position-4-1 {
    -webkit-transform: translate(363px, 0px);
    -moz-transform: translate(363px, 0px);
    -ms-transform: translate(363px, 0px);
    transform: translate(363px, 0px); }
  .tile.tile-position-4-2 {
    -webkit-transform: translate(363px, 121px);
    -moz-transform: translate(363px, 121px);
    -ms-transform: translate(363px, 121px);
    transform: translate(363px, 121px); }
  .tile.tile-position-4-3 {
    -webkit-transform: translate(363px, 242px);
    -moz-transform: translate(363px, 242px);
    -ms-transform: translate(363px, 242px);
    transform: translate(363px, 242px); }
  .tile.tile-position-4-4 {
    -webkit-transform: translate(363px, 363px);
    -moz-transform: translate(363px, 363px);
    -ms-transform: translate(363px, 363px);
    transform: translate(363px, 363px); }

  .tile .tile-inner {
    font-size: 35px; }

  .game-message p {
    font-size: 30px !important;
    height: 30px !important;
    line-height: 30px !important;
    margin-top: 90px !important; }
  .game-message .lower {
    margin-top: 30px !important; } }

/*# sourceMappingURL=main.cs.map */
