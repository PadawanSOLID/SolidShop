import httpInstance from "@/utils/http";

export function getCategoryAPI(id) {
    return httpInstance({
        url: '/good/findCategory',
        params: {
            id
        }
    })
}


export function getSubCategoryAPI(data) {
    return httpInstance({
        url: '/category/goods/temporary',
        method: 'POST',
        data
    })
}