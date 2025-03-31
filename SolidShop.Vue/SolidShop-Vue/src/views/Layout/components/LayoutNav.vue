<template>
    <nav class="app-topnav">
        <div class="container">
            <ul>
                <template v-if="true">
                    <li><a href="javascript:;"><i class="iconfont icon-user"></i>周杰伦</a></li>
                    <li>
                        <el-prpcornfirm title="确认退出吗？" confirm-button-text="确认" calcel-button-text="取消">
                            <template #reference>
                                <a href="#">退出登录</a>
                            </template>
                        </el-prpcornfirm>
                    </li>
                </template>
            </ul>
            <li><a href="#">我的订单</a></li>
            <li><a href="#">会员中心</a></li>
        </div>
    </nav>
</template>

<script setup>

</script>

<style lang="scss" scoped></style>