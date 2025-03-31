import httpInstance from "@/utils/http";

function getCategory() {
    return httpInstance({
        url: '/good/getCategory'
    })
}

export default getCategory