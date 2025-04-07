import httpInstance from '@/utils/http'

export default function getBannerAPI(params = {}) {
    const { distributionSite = '1' } = params
    return httpInstance({
        url: '/good/getBanner',
        params: {
            distributionSite
        }
    })
}

export function findNewAPI() {
    return httpInstance({
        url: '/good/findNew'
    })
}

export function getHostAPI() {
    return httpInstance({
        url: '/good/hot'
    })
}

export function getGoodsAPI() {
    return httpInstance({
        url: '/good/getGoods'
    })
}




