<template>
    <div class="app-topnav">
        <div class="container">
            <ul>
                <template v-if="true">
                    <li>
                        <a href="#"><i class="iconfont icon-user"></i>周杰伦</a>

                    </li>
                    <li>
                        <el-popconfirm title="确定要退出吗？" visible-arrow="false" cancel-button-text="取消"
                            confirm-button-text="确定">
                            <template #reference>
                                <a href="#">退出登录</a>
                            </template>
                        </el-popconfirm>
                    </li>
                    <li><a href="#">我的订单</a></li>
                    <li><a href="#">会员中心</a></li>
                </template>
                <template v-else>
                    <li><a href="#">请先登录</a></li>
                    <li><a href="#">帮助中心</a></li>
                    <li><a href="#">关于我们</a></li>
                </template>
            </ul>
        </div>
    </div>
</template>

<script setup>

</script>

<style lang="scss" scoped>
.app-topnav {
    border-color: #333;

    ul {
        display: flex;
        height: 53px;
        justify-content: flex-end;
        align-items: center;

        li {
            a {
                padding: 0 15px;
                color: #cdcdcd;
                line-height: 1;
                display: inline-block;

                i {
                    font-size: 14px;
                    margin-right: 2px;
                }

                &:hover {
                    color: $xtxColor;
                }
            }

            ~li {
                a {
                    border-left: 2px solid #666;
                }
            }
        }
    }
}

</style>