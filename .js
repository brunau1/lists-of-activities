var elements = document.querySelectorAll('a')
console.log(elements)
elements = [...elements]

var i = 0
var links = []
elements.map(item => {
    if (item.getAttribute('id') != 'back-link')
        links.push(item.getAttribute('href'))
})
elements.map(item => {
    if (item.getAttribute('id') != 'back-link')
        item.setAttribute('href', links[i].replace("https://abrasel.dj.emp.br/enrol/index.php?", ""))
    i++
    console.log(item.getAttribute('href'))
})
console.log(elements)
console.log(links)
elements.map(item => {
    if (item.getAttribute('id') != 'back-link')
        item.addEventListener('click', event => {
            event.preventDefault()
            links.map(link => {
                if (link.includes(item.getAttribute('href')))
                    localStorage.setItem("urlDestino", link)
            })

            var url = localStorage.getItem("urlDestino")
            console.log(url)
            var win = window.open("http://cursos.abrasel.com.br/formulario-de-cadastro-cursos/", '_blank');
            win.focus();
        }, false)
})