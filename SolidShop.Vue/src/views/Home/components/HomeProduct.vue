<template>
    <div class="home-product">
        <HomePanel :title="cate.name" :key="cate.id" v-for="cate in goodsProduct">
            <div class="box">
                <RouterLink class="cover" to="/">
                    <img v-img-lazy="cate.picture" :src="cate.picture" alt="">
                    <strong class="label">
                        <span>{{ cate.name }}馆</span>
                        <span>{{ cate.saleInfo }}</span>
                    </strong>
                </RouterLink>
                <ul class="good-list">
                    <li v-for="good in cate.goods" :key="good.id">
                        <GoodsItem :good></GoodsItem>
                    </li>
                </ul>
            </div>
        </HomePanel>
    </div>
</template>

<script setup>
import { getGoodsAPI } from '@/apis/home';
import HomePanel from './HomePanel.vue';
import GoodsItem from './GoodsItem.vue';
import { onMounted ,ref} from 'vue';

const goodsProduct=ref([])
const getGoods=async()=>{
    const res=await getGoodsAPI()
    goodsProduct.value=res
}
onMounted(()=>getGoods())
</script>

<style lang="scss" scoped>
.home-product{
    background: #fff;
    margin-top: 20px;
    .sub{
    margin-bottom: 2px;
    a{
        padding: 2px 12px;
        font-size: 16px;
        border-radius: 4px;
        &:hover{
            background: $xtxColor;
            color: #fff;
        }
        &:last-child{
            margin-right: 80px;
        }
    }
}
}

.box {
    display: flex;

    .cover {
        width: 240px;
        height: 610px;
        margin-right: 10px;
        position: relative;

        img {
            width: 100%;
            height: 100%;
        }

        .label {
            width: 188px;
            height: 66px;
            display: flex;
            font-size: 18px;
            color: #fff;
            line-height: 66px;
            font-weight: normal;
            position: absolute;
            left: 0;
            top: 50%;
            transform: translateY(-50%);

            span {
                text-align: center;

                &:first-child {
                    width: 76px;
                    background: rgba(0, 0, 0, 0.9);
                }

                &:last-child {
                    flex: 1;
                    background: rgba(0, 0, 0, 0.7);
                }
            }
        }
    }
}



.good-list {
    width: 990px;
    display: flex;
    flex-wrap: wrap;

    li {
        width: 240px;
        height: 300px;
        margin-right: 10px;
        margin-bottom: 10px;

        &:nth-last-child(-n+4) {
            margin-bottom: 0;
        }

        &:nth-child(4n) {
            margin-right: 0;
        }
    }
}


</style>