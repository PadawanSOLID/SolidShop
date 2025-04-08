import httpInstance from "@/utils/http";

export function getCategoryAPI(id) {
    return httpInstance({
        url: '/category/findCategory',
        params: {
            id
        }
    })
}


export function getSubCategoryAPI(data) {
    return httpInstance({
        url: '/good/GetSubCategoryGoods',
        method: 'POST',
        data
    })
}