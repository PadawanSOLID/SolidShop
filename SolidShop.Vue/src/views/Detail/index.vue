<template>
    <div class="txt-goods-page">
        <div class="container" v-if="goods.details">
            <div class="bread-container">
                <el-breadcrumb separator=">">
                    <el-breadcrumb-item :to="{ path: '/' }">首页</el-breadcrumb-item>
                    <el-breadcrumb-item :to="{ path: `/category/${goods.categories[1]?.id}` }">{{
                        goods.categories[1]?.name }}</el-breadcrumb-item>
                    <el-breadcrumb-item :to="{ path: `/category/sub/${goods.categories[0]?.id}` }">
                        {{ goods.categories[0]?.name }}
                    </el-breadcrumb-item>
                    <el-breadcrumb-item>{{ goods.name }}</el-breadcrumb-item>
                </el-breadcrumb>
            </div>
            <div class="info-container">
                <div>
                    <div class="goods-info">
                        <div class="media">
                            <ImageView :imageList="goods.details.pictures" />
                            <ul class="goods-sales">
                                <li>
                                    <p>销量人气</p>
                                    <p>{{ goods.salesCount }}+</p>
                                    <p><i class="iconfont icon-task-filling"></i>销量人气</p>
                                </li>
                                <li>
                                    <p>商品评价</p>
                                    <p>{{ goods.commentCount }}+</p>
                                    <p><i class="iconfont icon-comment-filling"></i>查看详情</p>
                                </li>
                                <li>
                                    <p>收藏人气</p>
                                    <p>{{ goods.collectCount }}+</p>
                                    <p><i class="iconfont icon-favorite-filling"></i>品牌主页</p>
                                </li>
                                <li>
                                    <p>品牌信息</p>
                                    <p>{{ goods.brand.name }}</p>
                                    <p><i class="iconfont icon-dynamic-filling"></i>品牌主页</p>
                                </li>
                            </ul>
                        </div>
                        <div class="spec">
                            <p class="g-name">{{ goods.name }}</p>
                            <p class="g-desc">{{ goods.desc }}</p>
                            <p class="g-price">
                                <span>{{ goods.oldPrice }}</span>
                                <span> {{ goods.price }}</span>
                            </p>
                            <div class="g-service">
                                <dl>
                                    <dt>促销</dt>
                                    <dd>12月好物</dd>
                                </dl>
                                <dl>
                                    <dt>服务</dt>
                                    <dd>
                                        <span>无忧退货</span>
                                        <span>快速退款</span>
                                        <span>免费包邮</span>
                                        <a href="#">了解详情</a>
                                    </dd>
                                </dl>
                            </div>
                            <!-- sku组件 -->
                            <!-- 数据组件 -->
                            <el-input-number v-model="count" @change="countChange" />
                            <!-- 按钮组件 -->
                            <div>
                                <el-button size="large" class="btn" @click="addCart">加入购物车</el-button>
                            </div>
                        </div>
                        <div class="goods-footer">
                            <div class="goods-article">
                                <div class="goods-tabs">
                                    <nav>
                                        <a>商品详情</a>
                                    </nav>
                                    <div class="goods-detail">
                                        <ul class="attrs">
                                            <li v-for="item in goods.details.properties" :key="item.value">
                                                <span class="dt">{{ item.name }}</span>
                                                <span class="dd">{{ item.value }}</span>
                                            </li>
                                        </ul>
                                        <img v-for="img in goods.details.pictures" :src="img" :key="img">
                                    </div>
                                </div>
                            </div>
                            <div class="goods-aside">
                                <DetailHot :hotType="1" />
                                <DetailHot :hotType="2" />
                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
</template>

<script setup>
import { getDetail } from '@/apis/detail';
import { onMounted, ref } from 'vue';
import { useRoute } from 'vue-router';
import DetailHot from './components/DetailHot.vue';
import { useCartStore } from '@/stores/cartStore'
const cartStore=useCartStore()
const count = ref(1)
const countChange = (count) => {
    console.log(count)
}
const addCart = () => {
    cartStore.addCart({
        id:goods.value.id,
        name:goods.value.name,
        picture:goods.value.details.pictures[0],
        price:goods.value.price,
        count:count.value,
    })
}
const route = useRoute()
const goods = ref({})
const getGoods = async () => {
    const res = await getDetail(route.params.id)
    console.log(res)
    goods.value = res
}
const skuChange = (sku) => {

}
onMounted(() => getGoods())
</script>

<style lang="scss" scoped>
.goods-tab {
    min-height: 600px;
    background: #fff;
}

.goods-warn {
    min-height: 600px;
    background: #fff;
    margin-top: 20px;
}

.goods-footer {
    display: flex;
    margin-top: 20px;

    .good-article {
        width: 940px;
        margin-right: 20px;
    }

    .goods-aside {
        width: 280px;
        min-height: 1000px;
    }
}

.goods-tabs {
    min-height: 600px;
    background: #fff;
}

.label {
    width: 60px;
    color: #999;
    padding-left: 10px;
}

.g-name {
    font-size: 22px;
}

.g-desc {
    color: #999;
    margin-top: 10px;
}

.g-price {
    margin-top: 10px;

    span {
        &::before {
            content: "￥";
            font-size: 14px;
        }
    }
}

.g-service {
    background: #f5f5f5;
    width: 500px;
    padding: 20px 10px 0 10px;
    margin-top: 10px;

    dl {
        padding-bottom: 20px;
        display: flex;
        align-items: center;
    }
}

.dt {
    width: 100px;
    color: #999;
}

.dd {
    flex: 1;
    color: #666;
}

.btn {
    margin-top: 20px;
}

.bread-container {
    padding: 25px 0;
}
</style>