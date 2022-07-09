# 教学辅助管理

## 本项目的使用方式
### 首先，确保已安装 Git 环境

https://git-scm.com/downloads

点击下载，并安装即可 (Windows 版本)

### 如果你本地还没有本项目，需要将其克隆到本地

打开 Git Bash 窗口，切换到某个文件夹，比如 D:/Workdir，然后使用 clone 命令下载:
```sh
cd d:/Workdir
git clone https://github.com/freelazy/TeachAssist
```

等执行完上述命令之后，你就会发现 D:/Workdir/TeachAssist 文件夹

### 通过 VS 打开项目，查看、运行项目

通过 VS 的 [文件] - [打开]，选定上述目录中的 .sln 文件，打开项目。

然后，就可以在 VS 中查看并运行项目了。

你也可以尝试对代码进行修改，并查看修改完成之后的运行效果。

### 后续更新

如果 github 上的项目已经有更新，那么你就需要进行 pull 操作了。

首先，切换到 D:/Workdir/TeachAssist 文件夹下:
```sh
cd D:/Workdir/TeachAssist
git status    # 查看目前仓库的状态
```

如果 git status 之后的结果是干净的，说明你没有对仓库进行修改，那么就可以直接更新了:
```sh
git pull
```

更新完毕，你就可以继续通过 vs 查看并运行项目了。

如果上面 git status 之后有一些红色的输出，说明你对当前项目进行了某些修改。
这时候你至少有两种选择:
1. 我不想保留我自己的修改，而是想将仓库还原为未修改的状态，然后更新。
   ```sh
   git checkout .
   git pull
   ```
2. 我想保留我的修改，也要将服务器上的内容更新到本地:
   - 需要创建一个新的分支，保存你的修改
   - 切换到主分支，完成 pull 操作
   - 这时候，主分支上是跟服务器同步的代码，其他分支则保留着你的修改
   - 示例:
	 ```sh
	 # 创建新分支，保存自己的修改
	 git branch my-branch-11
	 git checkout my-branch-11
	 git add .
	 git commit -m "我的修改注释"

	 # 切换到主分支，进行更新
	 git checkout master
	 git pull

	 # 然后，就可以随时切换，查看不同代码了
	 git checkout master/my-branch-11
	 ```

### 简而言之

```sh
# 第一次，要下载
git clone ...

# 后续的话，要更新
git pull
```

## 项目目的

1. 完成教学的相关辅助
2. 学习使用 Winform 构建基本的程序

## 基本功能

1. 学生管理
2. 点名
3. 提问
4. 测试
5. 面试题
6. 其他

### [模块] 点名

基本要求:
- 界面要简单高效
- 代码要逻辑清晰

### [模块] 提问

基本要求:
- 看得到所有人的积分、提问次数。可以排序。可以过滤
- 分为两种模式: 1) 提问某人 2) 提问某组
- 分为两种方式: 1) 手动指定 2) 随机选取
- 可以选中若干人组，然后随机时，会在选中的人组中进行
- 提问完成，需要能为回答的效果评分
- 要简洁、方便
