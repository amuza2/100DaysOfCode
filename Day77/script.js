const bio = document.getElementById("bio-btn");
const experience = document.getElementById("experience-btn");
const portfolio = document.getElementById("portfolio-btn");
const contact = document.getElementById("contact-btn");

const menuItem1 = document.getElementById("menu-item-1");
const menuItem2 = document.getElementById("menu-item-2");
const menuItem3 = document.getElementById("menu-item-3");
const menuItem4 = document.getElementById("menu-item-4");

const bioSection = document.getElementById("bio");
const experienceSection = document.getElementById("experience");
const portfolioSection = document.getElementById("portfolio");
const contactSection = document.getElementById("contact");

const personalInfo = document.getElementById("personal-info");

const bike1 = document.getElementById("bike1");
const bike2 = document.getElementById("bike2");

function btnClick(e) {
  bio.classList.remove("blue-line");
  experience.classList.remove("blue-line");
  portfolio.classList.remove("blue-line");
  contact.classList.remove("blue-line");

  menuItem1.classList.remove("active-bg");
  menuItem2.classList.remove("active-bg");
  menuItem3.classList.remove("active-bg");
  menuItem4.classList.remove("active-bg");

  bioSection.classList.add("display-none");
  experienceSection.classList.add("display-none");
  portfolioSection.classList.add("display-none");
  contactSection.classList.add("display-none");

  bioSection.classList.remove("display-block");
  experienceSection.classList.remove("display-block");
  portfolioSection.classList.remove("display-block");
  contactSection.classList.remove("display-block");

  if (e === "bio") {
    bio.classList.add("blue-line");
    menuItem1.classList.add("active-bg");
    bioSection.classList.add("display-block");
    personalInfo.classList.remove("small-header");
  } else if (e === "experience") {
    experience.classList.add("blue-line");
    menuItem2.classList.add("active-bg");
    experienceSection.classList.add("display-block");
    personalInfo.classList.add("small-header");
  } else if (e === "portfolio") {
    portfolio.classList.add("blue-line");
    menuItem3.classList.add("active-bg");
    portfolioSection.classList.add("display-block");
    personalInfo.classList.add("small-header");
  } else if (e === "contact") {
    contact.classList.add("blue-line");
    menuItem4.classList.add("active-bg");
    contactSection.classList.add("display-block");
    personalInfo.classList.add("small-header");
  }
}

let seconds = 0;
let count = 0;
setInterval(() => {
  const hour = Math.floor(seconds / 3600);
  const minute = Math.floor((seconds - hour * 3600) / 60);
  const updSecond = seconds - (hour * 3600 + minute * 60);

  if (seconds % 10 === 0) {
    bike2.classList.remove("animationBottom");
    bike1.classList.add("animationTop");
  }

  if (seconds % 20 === 10) {
    bike1.classList.remove("animationTop");
    bike2.classList.add("animationBottom");
  }

  ++seconds;
}, 1000);
