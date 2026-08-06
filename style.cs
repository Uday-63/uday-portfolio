* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  }

html {
scroll-behavior: smooth;
}

body {
font-family: "Poppins", Arial, sans-serif;
background: #07111f;
color: #e8f0f7;
line-height: 1.7;
}

/* ================= WELCOME SECTION ================= */

.welcome-section {
min-height: 100vh;

display: flex;
justify-content: center;
align-items: center;

text-align: center;

padding: 30px;

background:
radial-gradient(circle at top left, #12345b, transparent 40%),
radial-gradient(circle at bottom right, #073b4c, transparent 40%),
#050b14;

border-bottom: 2px solid #1e88e5;
}

.welcome-content {
max-width: 900px;

padding: 60px 40px;

border: 1px solid rgba(255,255,255,0.15);

border-radius: 25px;

background: rgba(255,255,255,0.05);

backdrop-filter: blur(10px);

box-shadow: 0 20px 60px rgba(0,0,0,0.5);
}

.welcome-badge {
display: inline-block;

padding: 8px 20px;

margin-bottom: 25px;

border: 1px solid #00c6ff;

border-radius: 30px;

color: #00c6ff;

font-size: 14px;

letter-spacing: 2px;

font-weight: 600;
}

.welcome-section h1 {
font-size: 60px;

margin-bottom: 15px;

color: white;
}

.welcome-section h1 span {
color: #00c6ff;
}

.welcome-section h2 {
font-size: 34px;

color: #ffffff;

margin-bottom: 10px;
}

.welcome-section p {
color: #b8c7d9;

font-size: 18px;
}

.welcome-description {
max-width: 650px;

margin: 20px auto 30px;

font-size: 16px !important;
}

/* RESUME BUTTON */

.resume-btn {
padding: 14px 32px;

border: none;

border-radius: 30px;

background: linear-gradient(
135deg,
#00c6ff,
#0072ff
);

color: white;

font-size: 16px;

font-weight: 600;

cursor: pointer;

transition: 0.3s;

box-shadow: 0 8px 25px rgba(0,114,255,0.3);
}

.resume-btn:hover {
transform: translateY(-4px);

box-shadow: 0 12px 35px rgba(0,198,255,0.4);
}

/* ================= HEADER ================= */

header {
background: #0a1728;

padding: 35px 20px;

border-bottom: 1px solid #1d3d5c;
}

.profile {
max-width: 1100px;

margin: auto;

display: flex;

align-items: center;

gap: 30px;
}

.profile-pic {
width: 140px;
height: 140px;

object-fit: cover;

border-radius: 50%;

border: 4px solid #00c6ff;

box-shadow:
0 0 25px rgba(0,198,255,0.4);
}

.profile h1 {
font-size: 40px;

color: white;
}

.profile h3 {
color: #00c6ff;

font-size: 22px;

margin: 5px 0;
}

.profile-summary {
color: #9db1c5;
}

/* ================= NAVIGATION ================= */

nav {
position: sticky;

top: 0;

z-index: 1000;

background: rgba(5,15,27,0.95);

backdrop-filter: blur(10px);

border-bottom: 1px solid #1c3d59;
}

nav ul {
list-style: none;

display: flex;

justify-content: center;

flex-wrap: wrap;

gap: 5px;

padding: 15px;
}

nav ul li a {
color: #dbe8f5;

text-decoration: none;

padding: 8px 15px;

border-radius: 20px;

transition: 0.3s;
}

nav ul li a:hover {
background: #00c6ff;

color: #06101d;
}

/* ================= COMMON CARD ================= */

.card {
max-width: 1050px;

margin: 35px auto;

padding: 35px;

background: #0c1b2d;

border: 1px solid #1c3c58;

border-radius: 15px;

box-shadow: 0 10px 30px rgba(0,0,0,0.25);

transition: 0.3s;
}

.card:hover {
border-color: #00c6ff;

transform: translateY(-3px);

box-shadow:
0 15px 40px rgba(0,198,255,0.08);
}

.card h2 {
text-align: center;

font-size: 30px;

margin-bottom: 25px;

color: #00c6ff;

position: relative;
}

.card h2::after {
content: "";

display: block;

width: 60px;

height: 3px;

background: #00c6ff;

margin: 10px auto;
}

.card p {
color: #c2d0dd;

margin-bottom: 15px;
}

/* ================= SKILLS ================= */

.skills-grid {
display: grid;

grid-template-columns:
repeat(3, 1fr);

gap: 20px;
}

.skill-box {
padding: 25px;

border: 1px solid #254863;

border-radius: 12px;

background: #091625;

transition: 0.3s;
}

.skill-box:hover {
border-color: #00c6ff;

transform: translateY(-5px);
}

.skill-box h3 {
color: #00c6ff;

margin-bottom: 10px;
}

.skill-box p {
font-size: 14px;
}

/* ================= EXPERIENCE ================= */

.experience-box {
padding: 25px;

border-left: 4px solid #00c6ff;

background: #091625;

border-radius: 8px;
}

.experience-box h3 {
color: white;

font-size: 24px;
}

.experience-duration {
color: #00c6ff !important;

font-weight: 600;
}

.experience-box ul {
margin-top: 15px;

padding-left: 25px;
}

.experience-box li {
margin-bottom: 10px;

color: #c4d1dd;
}

/* ================= PROJECT ================= */

.project-card {
padding: 30px;

background: #091625;

border: 1px solid #254863;

border-radius: 12px;

border-left: 4px solid #00c6ff;
}

.project-card h3 {
color: white;

font-size: 24px;

margin-bottom: 10px;
}

.project-card h4 {
margin: 20px 0 10px;

color: #00c6ff;
}

.project-card ul {
padding-left: 25px;
}

.project-card li {
margin-bottom: 8px;

color: #c4d1dd;
}

.project-tech {
display: flex;

flex-wrap: wrap;

gap: 10px;

margin: 20px 0;
}

.project-tech span {
padding: 6px 14px;

border-radius: 20px;

background: #102c43;

border: 1px solid #286184;

color: #00c6ff;

font-size: 13px;
}

/* ================= RESPONSIBILITIES ================= */

#roles ul {
padding-left: 25px;
}

#roles li {
margin-bottom: 12px;

color: #c4d1dd;
}

#roles li::marker {
color: #00c6ff;
}

/* ================= CONTACT ================= */

.contact-section {
text-align: center;
}

.contact-links {
display: flex;

justify-content: center;

flex-wrap: wrap;

gap: 15px;

margin-top: 25px;
}

.contact-links a {
text-decoration: none;

color: white;

background: #102c43;

border: 1px solid #286184;

padding: 12px 22px;

border-radius: 25px;

transition: 0.3s;
}

.contact-links a:hover {
background: #00c6ff;

color: #06101d;

transform: translateY(-3px);
}

/* ================= FOOTER ================= */

footer {
text-align: center;

padding: 30px 15px;

background: #050b14;

border-top: 1px solid #1d3d5c;

color: #8fa4b8;
}

footer p {
margin: 5px;
}

/* ================= MOBILE ================= */

@media (max-width: 768px) {

.welcome-section h1 {
font-size: 40px;
}

.welcome-section h2 {
font-size: 25px;
}

.welcome-content {
padding: 40px 20px;
}

.profile {
flex-direction: column;

```
text-align: center;
```

}

.profile h1 {
font-size: 32px;
}

.skills-grid {
grid-template-columns: 1fr;
}

.card {
margin: 20px 15px;

```
padding: 25px 20px;
```

}

nav ul {
gap: 8px;
}

nav ul li a {
font-size: 13px;

```
padding: 6px 10px;
```

}

}
