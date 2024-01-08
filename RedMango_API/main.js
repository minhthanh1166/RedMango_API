// Lấy tất cả các phần tử div trên trang
var divElements = document.getElementsByTagName("div");

// Duyệt qua từng phần tử div
for (var i = 0; i < divElements.length; i++) {
    var divElement = divElements[i];

    // Kiểm tra style của phần tử div
    var divStyle = window.getComputedStyle(divElement);

    // Nếu style là display: flex và z-index: 999999, thì chuyển đổi sang display: none
    if (divStyle.display === "flex" && divStyle.zIndex === "999999") {
        divElement.style.display = "none";
    }
}