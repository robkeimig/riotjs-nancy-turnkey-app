# RiotJS turnkey app with Nancy hosting

This project demonstrates a simple single-page web application stack.

### Features
- Fully-integrated [Nancy](http://nancyfx.org/) hosting (API + web content)
- Simple, bare-bones SPA architecture using [RiotJS](http://riotjs.com/)
- [Twitter Boostrap](http://getbootstrap.com/) for making things look decent
- Demonstrates routing, session management, nested views, observables
- Session management utilizing [JWT](https://en.wikipedia.org/wiki/JSON_Web_Token) for easily scaling up to cloud-based hosting
- Runs on top of .NET core (Linux/Windows/OSX)
- Back-end utilizes [EF Core](https://docs.microsoft.com/en-us/ef/) w/ [SQLite provider](https://docs.microsoft.com/en-us/ef/core/providers/sqlite/) for persistence
- No NPM shenanigans - Dependency management purely via NuGet and JS CDN (or local hosting as desired)

### Hacking the web application
Hit F5 in VS15/VSCode and load the WebContent folder in your favorite editor. Refresh browser as needed. It can be this easy.

### Hacking the .NET back-end
Same as above.

### Demo
Click [Here](#) for a demonstration of what this project currently looks like when running.

### Use cases

##### Intranet/Low-Traffic Internet
This project as-is would be suitable for small to medium-sized web applications that run on intranet or lower-traffic internet sites. The entire stack can easily be built and deployed for hosting on a single box.

##### "Webscale"
The back-end can be thrown out and easily swapped to use a cloud-based API on top of AWS or similar platforms. All that you need to do is serve the contents of `/WebContent` out of a CDN (S3, et. al.) and point the URL inside `endpoint.js` at whatever backend provides the API.

### Motivation
The current popular ecosystem of NPM dependency management has become very complex and prone to breakage <sup id="a1">[1](#f1)</sup> <sup id="a2">[2](#f2)</sup> <sup id="a3">[3](#f3)</sup>. This project is intended as proof that modern web experiences are possible with minimal JS library usage and a non-existent web content build pipeline. The performance and simplicity of [vanilla js](http://vanilla-js.com/) is often overlooked in light of perceived convienences afforded by various libraries. 

<b id="f1">1</b> [Visual Studio Code Breaks NPM](https://adtmag.com/articles/2016/11/03/vscode-rollback.aspx) [↩](#a1)
<b id="f2">2</b> [Left-Pad removal from NPM breaks everything](http://blog.npmjs.org/post/141577284765/kik-left-pad-and-npm) [↩](#a2)
<b id="f3">3</b> [Windows node_modules path length issue](https://github.com/nodejs/node-v0.x-archive/issues/6960) [↩](#a3)
