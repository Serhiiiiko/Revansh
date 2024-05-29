﻿//function setTheme(mode = 'auto') {
//    const userMode = localStorage.getItem('bs-theme');
//    const sysMode = window.matchMedia('(prefers-color-scheme: light)').matches;
//    const useSystem = mode === 'system' || (!userMode && mode === 'auto');
//    const modeChosen = useSystem ? 'system' : mode === 'dark' || mode === 'light' ? mode : userMode;

//    if (useSystem) {
//        localStorage.removeItem('bs-theme');
//    } else {
//        localStorage.setItem('bs-theme', modeChosen);
//    }

//    document.documentElement.setAttribute('data-bs-theme', useSystem ? (sysMode ? 'light' : 'dark') : modeChosen);
//    document.querySelectorAll('.mode-switch .btn').forEach(e => e.classList.remove('text-white'));
//    document.getElementById(modeChosen).classList.add('text-white');
//}

//setTheme();
//document.querySelectorAll('.mode-switch .btn').forEach(e => e.addEventListener('click', () => setTheme(e.id)));
//window.matchMedia('(prefers-color-scheme: light)').addEventListener('change', () => setTheme());

function copyToClipboard(text) {
    const el = document.createElement('textarea');
    el.value = text;
    document.body.appendChild(el);
    el.select();
    document.execCommand('copy');
    document.body.removeChild(el);
    alert('Text copied');
}