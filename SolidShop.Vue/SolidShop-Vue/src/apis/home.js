import httpInstance from '@/utils/http'

export default function getBannerAPI() {
    return httpInstance({
        url: '/good/getBanner'
    })
}

export function findNewAPI() {
    return httpInstance({
        url: '/good/findNew'
    })
}

export function getHostAPI(){
    return httpInstance({
        url:'/good/hot'
    })
}

export function getGoodsAPI(){
    return httpInstance({
        url:'/home/goods'
    })
}

 
