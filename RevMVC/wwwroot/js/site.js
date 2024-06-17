function copyToClipboard(text) {
    const el = document.createElement('textarea');
    el.value = text;
    document.body.appendChild(el);
    el.select();
    document.execCommand('copy');
    document.body.removeChild(el);
    alert('Text copied');
}

function copyText(elementId) {
    var copyText = document.getElementById(elementId).innerText;
    var textarea = document.createElement("textarea");
    textarea.value = copyText;
    document.body.appendChild(textarea);
    textarea.select();
    document.execCommand("copy");
    document.body.removeChild(textarea);
    alert("Copied: " + copyText);
}
document.addEventListener('DOMContentLoaded', function () {
    var imageModal = document.getElementById('imageModal');
    imageModal.addEventListener('show.bs.modal', function (event) {
        var button = event.relatedTarget;
        var imageUrl = button.getAttribute('data-bs-image');
        var modalImage = document.getElementById('modalImage');
        modalImage.src = imageUrl;
    });
});
