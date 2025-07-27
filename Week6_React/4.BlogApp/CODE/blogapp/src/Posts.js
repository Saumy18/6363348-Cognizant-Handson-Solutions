import React, { Component } from 'react';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: []
    };
  }

  componentDidMount() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => this.setState({ posts: data }));
  }

  render() {
    return (
      <div>
        <h2>All Blog Posts</h2>
        {this.state.posts.map(post => (
          <div key={post.id}>
            <p><strong>User ID:</strong> {post.userId}</p>
            <p><strong>Post ID:</strong> {post.id}</p>
            <p><strong>Title:</strong> {post.title}</p>
            <p><strong>Body:</strong> {post.body}</p>
            <hr />
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
