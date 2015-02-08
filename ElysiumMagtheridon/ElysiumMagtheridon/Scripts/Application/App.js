$(document).ready(function () {
    var backgroundImages = [
    "https://bnetcmsus-a.akamaihd.net/cms/content_entry_media/HPSXSOS898LZ1407247543349.jpg",
    "http://junkiesnation.com/wp-content/uploads/2013/11/shadowmoon-valley.jpg",
    "https://bnetcmsus-a.akamaihd.net/cms/content_folder_media/Q3HYY40K9T4W1398905754572.jpg",
    "http://www.wowjuju.com/wp-content/uploads/2014/07/Talador_01.jpg",
    "https://fbcdn-sphotos-e-a.akamaihd.net/hphotos-ak-xfa1/t31.0-8/p960x960/10560484_686876084733985_686544119331246801_o.jpg",
    "http://media.blizzard.com/wow/media/screenshots/screenshot-of-the-day/warlords-of-draenor/warlords-of-draenor-ss0021-full.jpg",
    "http://wowweekly.net/wp-content/uploads/2014/07/Horde-Beta-Garrison-background.jpg",
    "http://www.wowjuju.com/wp-content/uploads/2014/07/Tanaan_Jungle_02.jpg"
    ];
    var background = parseInt(Math.random() * backgroundImages.length - 1);

    $(".background").css("background-image", "url('" + backgroundImages[background] + "')");
});